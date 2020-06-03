using _3DOK_API.Data;
using _3DOK_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
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
    }
}
