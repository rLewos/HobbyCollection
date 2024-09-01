using Games.Model;
using Games.Service;
using Games.Service.Interfaces;
using HobbyCollection.Website.Controllers;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Games.Controllers
{
    public class GameController : BaseController
	{
        private IGameService _gameService;

        public GameController(IGameService gameService) {
            _gameService = gameService;
        }

		#region Views

		public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List() {
            GameViewModel vm = new GameViewModel();
            vm.GameList = _gameService.ListAll();

            return View(vm);
        }

        public IActionResult Add()
        {
            GameViewModel viewModel = new GameViewModel();
            viewModel.Game = new Game();

            return View(viewModel);
        }

        public IActionResult Detail(int? id) {

            GameViewModel vm = new GameViewModel();
            vm.Game = _gameService.GetById(id.Value);

            return View(vm);
        }

        public IActionResult Edit(int? idGame)
        {
            GameViewModel vm = new GameViewModel();
            vm.Game = _gameService.GetById(idGame.Value);

            return View("Add", vm);
        }

		#endregion

		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(GameViewModel vm) 
        {
            try
            {
				_gameService.Save(vm.Game);
			}
			catch (Exception e)
			{
				return this.Json(false, "Game couldn't be saved.");
			}

			return this.Json(true, "Game has been saved sucessfully.");
        }

		[HttpPost]
		public IActionResult Delete(int? idGame)
		{
			_gameService.Delete(idGame.Value);

			return View();
		}

	}
}
