using Hobby.Service.Interfaces;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class DeveloperController : Controller
	{
		private readonly IDeveloperService _developerService;

		public DeveloperController(IDeveloperService developerService)
		{
			this._developerService = developerService;
		}

		#region Views

		public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			DeveloperViewModel vm = new DeveloperViewModel();
			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(DeveloperViewModel vm)
		{


			return RedirectToAction("List");
		}


	}
}
