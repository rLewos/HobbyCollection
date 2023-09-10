using Games.Model;
using Games.Service;
using Games.Service.Interfaces;
using Games.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Games.Controllers
{
    public class GameController : Controller
    {
        private IGameService _gameService;

        public GameController(IGameService gameService) {
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            GameViewModel vm = new GameViewModel();
            
            Game game = new Game { 
                Name = "Test",
                ReleaseDate = DateTime.Now,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
			
			_gameService.Save(game);
			
            game = new Game
			{
				Name = "Test 2",
				ReleaseDate = DateTime.Now,
				IsActive = true,
				CreatedDate = DateTime.Now,
				UpdatedDate = DateTime.Now
			};

			_gameService.Save(game);
			vm.GameList = _gameService.List();

            return View(vm);
        }

        public IActionResult List() {
            GameViewModel vm = new GameViewModel();
            vm.GameList = _gameService.List();

            return View(vm);
        }

        public IActionResult Add()
        {
            GameViewModel viewModel = new GameViewModel();
            viewModel.Game = new Game();
            return View(viewModel);
        }

        [HttpPost]
        public JsonResult Save(GameViewModel vm) {
            
            _gameService.Save(vm.Game);
            return Json(new { });
        }

    }
}
