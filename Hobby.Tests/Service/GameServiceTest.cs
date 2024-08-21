using Games.Model;
using Games.Service;
using Games.Service.Interfaces;
using Games.Tests;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Hobby.Tests.Service
{
    public class GameServiceTest
    {
        private IGameService _gameService;

        public GameServiceTest()
        {
            _gameService = TestsBase.GetService<IGameService>();
        }

        [Fact]
        public void Add()
        {
            // Arrange
            Game game = new Game();
            game.Name = "Game TDD";
            game.ReleaseDate = DateTime.Now;

            game.IsActive = true;
            game.CreatedDate = DateTime.Now;
            game.UpdatedDate = DateTime.Now;

            // Act
            _gameService.Save(game);

            // Assert
            Assert.True(game.Id > 0);
        }

        [Fact]
        public void Update() {
            
            Game? game = _gameService.GetByName("Game TDD");

            game.Name = "Game test v2";
            _gameService.Save(game);
            Game returnedGame = _gameService.GetById(game.Id);

            Assert.Equal(game.Name, returnedGame.Name);
        }

        [Fact]
        public void Get()
        {
			// Arrange
			Game game = new Game();
			game.Name = "Game TDD";
			game.ReleaseDate = DateTime.Now;

			game.IsActive = true;
			game.CreatedDate = DateTime.Now;
			game.UpdatedDate = DateTime.Now;
            _gameService.Save(game);

			// Act
			game = _gameService.GetById(game.Id);

            // Asset
            Assert.NotNull(game);
        }

        [Fact]
        public void GetByName() {
            string? gameName = "Game TDD";

            Game? game = _gameService.GetByName(gameName);

            Assert.NotNull(game);
            Assert.Equal(game.Name, gameName);
        }

        [Fact]
        public void List()
        {
            //Arrange
            //Act
            IList<Game>? gameList = _gameService.ListAll();

            // Assert
            Assert.NotNull(gameList);
            Assert.True(gameList.Count > 0);
        }

        [Fact]
        public void Remove()
        {
            // Arrange
            Game? game = _gameService.GetByName("Game TDD");

            // Act
            _gameService.Delete(game.Id);
            Game? gameAssert = _gameService.GetById(game.Id);

            // Assert
            Assert.Null(gameAssert);
        }

    }
}
