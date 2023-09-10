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
			//game.Id = 1;
			game.Name = "test";
			game.ReleaseDate = DateTime.Now;
			
			game.IsActive = true;
			game.CreatedDate = DateTime.Now;
			game.UpdatedDate = DateTime.Now;

			// Act
			_gameService.Save(game);
			Game returnedGame = _gameService.List().FirstOrDefault();

			// Assert
			Assert.Equal(game.Id, game.Id);
		}

		[Fact(Skip = "")] 
		public void Remove() { }
		
		[Fact(Skip = "")] 
		public void Get() { }
		
		[Fact] 
		public void List() {
			
			IList<Game>? gameList =_gameService.List();
			
			Assert.NotNull(gameList);
			Assert.True(gameList.Count > 0);

		}

	}
}
