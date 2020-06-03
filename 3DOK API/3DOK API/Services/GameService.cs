using _3DOK_API.Data;
using _3DOK_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Services
{
    public interface IGameService
    {
        public List<Game> GetGames();
        public Game GetGame(int id);
        public Game CreateGame(Game game);
        public void UpdateGame(Game game);
        public void DeleteGame(int id);
    }

    public class GameService : IGameService
    {
        private ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Game CreateGame(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();
            return game;
        }

        public void DeleteGame(int id)
        {
            Game gameToDelete = GetGame(id);
            if (gameToDelete != null)
            {
                _context.Game.Remove(gameToDelete);
                _context.SaveChanges();
            }
        }

        public Game GetGame(int id)
        {
            return _context.Game.FirstOrDefault(gt => gt.Id == id);
        }

        public List<Game> GetGames()
        {
            return _context.Game.ToList();
        }

        public void UpdateGame(Game game)
        {
            Game gameToEdit = GetGame(game.Id);
            if (gameToEdit != null)
            {
                gameToEdit = game;
                _context.SaveChanges();
            }
        }
    }
}
