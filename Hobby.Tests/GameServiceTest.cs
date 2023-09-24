using Games.Model;
using Games.Service;
using Games.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Games.Tests
{
	public class GameServiceTest
	{
		private IGameService _gameService;

		public GameServiceTest() {
			this._gameService = TestsBase.GetService<IGameService>();
		}

		[Fact]
		public void Add()
		{
			// Arrange
			Game game = new Game();
			game.Name = "Game Test";
			game.ReleaseDate = DateTime.Now;
			
			game.IsActive = true;
			game.CreatedDate = DateTime.Now;
			game.UpdatedDate = DateTime.Now;

			// Act
			_gameService.Save(game);
			Game returnedGame = _gameService.Get(game.Id);

			// Assert
			Assert.Equal(game.Id, game.Id);
		}
		
		[Theory]
		[InlineData(1)]
		public void Get(int idGame) {
			// Arrange
			// Act
			Game game = _gameService.Get(idGame);

			// Asset
			Assert.NotNull(game);
		}
		
		[Fact] 
		public void List() {
			//Arrange
			//Act
			IList<Game>? gameList =_gameService.List();
			
			// Assert
			Assert.NotNull(gameList);
			Assert.True(gameList.Count > 0);
		}

		[Theory]
		[InlineData(1)]
		public void Remove(int? idGame) {
			// Arrange
			// Act
			_gameService.Delete(idGame);
			Game? game = _gameService.Get(idGame);

			// Assert
			Assert.Null(game);
		}
	}
}
