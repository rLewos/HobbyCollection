using Hobby.Service.Interfaces;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class PlatformController : BaseController
	{
		private readonly IPlatformService _iPlatformService;
        public PlatformController(IPlatformService iPlatformService)
        {
            this._iPlatformService = iPlatformService;
        }

        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			PlatformViewModel vm = new PlatformViewModel();
			vm.PlataformList = _iPlatformService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(PlatformViewModel vm)
		{
			try
			{
				_iPlatformService.Save(vm.Plataform);
			}
			catch (Exception e)
			{
				return this.Json(false, "Plataform couldn't be saved.");
			}

			return this.Json(true, "Plataform has been saved sucessfully.");
		}
	}
}
