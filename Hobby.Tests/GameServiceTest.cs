using Games.Model;
using Games.Service.Interfaces;
using Games.Tests;
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
            Game game = this.GetGame();
            game.Name = "Game ADD Test";

            // Act
            _gameService.Save(game);

            // Assert
            Assert.True(game.Id > 0);
        }

        [Fact]
        public void Update() {
            
            Game? game = _gameService.GetByName("Game TDD");

            game.Name = "Game UPDATE Test";
            _gameService.Save(game);
            Game returnedGame = _gameService.GetById(game.Id);

            Assert.Equal(game.Name, returnedGame.Name);
        }

        [Fact]
        public void Get()
        {
			// Arrange
            Game game = this.GetGame();
            game.Name = "Game GET test";
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

        public Game GetGame()
        {
            return new Game()
            {
                Name = "Game",
                ReleaseDate = DateTime.Now,

                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
        }

    }
}
