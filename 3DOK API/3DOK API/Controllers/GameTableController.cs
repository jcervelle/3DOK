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
    public class GameTableController : ControllerBase
    {
        private readonly ILogger<GameTableController> _logger;
        private readonly IGameTableService _gameTableService;

        public GameTableController(ILogger<GameTableController> logger, IGameTableService gameTableService)
        {
            _logger = logger;
            _gameTableService = gameTableService;
        }

        [HttpGet]
        public IEnumerable<GameTable> GetAll()
        {
            _logger.LogInformation("Retrieving users");
            return _gameTableService.GetGameTables();
        }

        [HttpGet("{id}")]
        public GameTable Get(int id)
        {
            _logger.LogInformation($"Retrieving gameTable {id}");
            return _gameTableService.GetGameTable(id);
        }

        [HttpPost]
        public GameTable Post(GameTable gameTable)
        {
            _logger.LogInformation("Creating gameTable");
            return _gameTableService.CreateGameTable(gameTable);
        }

        [HttpPut]
        public void Put(GameTable gameTable)
        {
            _logger.LogInformation("Updating gameTable");
            _gameTableService.UpdateGameTable(gameTable);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _logger.LogInformation("Deleting gameTable");
            _gameTableService.DeleteGameTable(id);
        }
    }
}
