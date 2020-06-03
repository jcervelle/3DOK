using _3DOK_API.Data;
using _3DOK_API.Model;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DOK_API.Services
{
    public interface IGameTableService
    {
        public List<GameTable> GetGameTables();
        public GameTable GetGameTable(int id);
        public GameTable CreateGameTable(GameTable gameTable);
        public void UpdateGameTable(GameTable gameTable);
        public void DeleteGameTable(int id);
    }

    public class GameTableService : IGameTableService
    {
        private ApplicationDbContext _context;

        public GameTableService(ApplicationDbContext context)
        {
            _context = context;
        }

        public GameTable CreateGameTable(GameTable gameTable)
        {
            _context.Add(gameTable);
            _context.SaveChanges();
            return gameTable;
        }

        public void DeleteGameTable(int id)
        {
            GameTable gameTableToDelete = GetGameTable(id);
            if(gameTableToDelete != null)
            {
                _context.GameTable.Remove(gameTableToDelete);
                _context.SaveChanges();
            }
        }

        public GameTable GetGameTable(int id)
        {
            return _context.GameTable.FirstOrDefault(gt => gt.Id == id);
        }

        public List<GameTable> GetGameTables()
        {
            return _context.GameTable.ToList();
        }

        public void UpdateGameTable(GameTable gameTable)
        {
            GameTable gameTableToEdit = GetGameTable(gameTable.Id);
            if (gameTableToEdit != null)
            {
                gameTableToEdit = gameTable;
                _context.SaveChanges();
            }
        }
    }
}
