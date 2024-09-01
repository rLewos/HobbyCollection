using Hobby.Service.Interfaces;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class PlataformController : BaseController
	{
		private readonly IPlataformService _plataformService;
        public PlataformController(IPlataformService plataformService)
        {
            this._plataformService = plataformService;
        }

        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			PlataformViewModel vm = new PlataformViewModel();
			vm.PlataformList = _plataformService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(PlataformViewModel vm)
		{
			try
			{
				_plataformService.Save(vm.Plataform);
			}
			catch (Exception e)
			{
				return this.Json(false, "Plataform couldn't be saved.");
			}

			return this.Json(true, "Plataform has been saved sucessfully.");
		}
	}
}
