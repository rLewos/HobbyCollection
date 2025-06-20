using HobbyCollection.Website.Models.DTO;
using HobbyCollection.Website.ViewModels;
using HobbyCollection.Website.Service;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class PlatformController : BaseController
	{
		private readonly IPlatformService _platformService;
        public PlatformController(IPlatformService iPlatformService)
        {
            _platformService = iPlatformService;
        }

        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			PlatformViewModel vm = new PlatformViewModel();
			//vm.PlataformList = _platformService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		public async Task<IActionResult> Detail(int id)
		{
			var vm = new PlatformViewModel();
			vm.Plataform = await _platformService.GetById(id);
			
			return View(vm);
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(PlatformViewModel vm)
		{
			try
			{
				//_iPlatformService.Save(vm.Plataform);
			}
			catch (Exception e)
			{
				return this.Json(false, "Plataform couldn't be saved.");
			}

			return this.Json(true, "Plataform has been saved sucessfully.");
		}
	}
}
