using _3DOK_API.Data;
using _3DOK_API.Model;
using _3DOK_API.Security;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _3DOK_API.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public User CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
        public User Authenticate(string email, string password);
        public User CheckToken(string token);

    }

    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        IPasswordHasher _passwordHasher;
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings, ApplicationDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _appSettings = appSettings.Value;
        }

        public User Authenticate(string email, string password)
        {
            var user = _context.User.Single(user => user.Email == email);

            // return null if user not found
            if (user == null)
                return null;


            if (!_passwordHasher.Check(password, user.Password))
            {
                return null;
            }

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return WithoutPassword(user);
        }

        public User CheckToken(string token)
        {
            JwtSecurityTokenHandler jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = jwtTokenHandler.ReadJwtToken(token);
            if (DateTime.Now > jwtToken.ValidTo)
            {
                return null;
            }
            int idUser = int.Parse(jwtToken.Claims
                                    .Where(x => x.Type == "unique_name")
                                    .FirstOrDefault().Value);
            User user = _context.User.FirstOrDefault(x => x.Id == idUser);
            if (user == null)
            {
                return null;
            }
            user.Token = token;
            return WithoutPassword(user);
        }

        public User CreateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            User userToDelete = GetUser(id);
            if(userToDelete != null)
            {
                _context.Remove(userToDelete);
                _context.SaveChanges();
            }
        }

        public User GetUser(int id)
        {
            return _context.User.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public void UpdateUser(User user)
        {
            User userToEdit = GetUser(user.Id);
            if(userToEdit != null)
            {
                userToEdit = user;
                _context.SaveChanges();
            }
        }

        private User WithoutPassword(User user)
        {
            user.Password = null;
            return user;
        }
    }
}
