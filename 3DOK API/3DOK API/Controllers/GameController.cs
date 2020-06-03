using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3DOK_API.Model;
using _3DOK_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _3DOK_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IGameService _gameService;

        public GameController(ILogger<UserController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        [HttpGet]
        public IEnumerable<Game> GetAll()
        {
            _logger.LogInformation("Retrieving users");
            return _gameService.GetGames();
        }

        [HttpGet("{id}")]
        public Game Get(int id)
        {
            _logger.LogInformation($"Retrieving user {id}");
            return _gameService.GetGame(id);
        }

        [HttpPost]
        public Game Post(Game game)
        {
            _logger.LogInformation("Creating user");
            return _gameService.CreateGame(game);
        }

        [HttpPut]
        public void Put(Game game)
        {
            _logger.LogInformation("Updating user");
            _gameService.UpdateGame(game);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _logger.LogInformation("Deleting user");
            _gameService.DeleteGame(id);
        }
    }
}
