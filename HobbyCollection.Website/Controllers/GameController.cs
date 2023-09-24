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

		#region Views

		public IActionResult Index()
        {
            return RedirectToAction("List");
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

        public IActionResult Detail(int? idGame) {

            GameViewModel vm = new GameViewModel();
            vm.Game = _gameService.Get(idGame.Value);

            return View(vm);
        }

        public IActionResult Edit(int? idGame)
        {
            GameViewModel vm = new GameViewModel();
            vm.Game = _gameService.Get(idGame);

            return View(vm);
        }

		#endregion

		[HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Save(GameViewModel vm) {
            _gameService.Save(vm.Game);

            return Json(new { });
        }

		[HttpPost]
		public IActionResult Delete(int? idGame)
		{
			_gameService.Delete(null);

			return View();
		}

	}
}
