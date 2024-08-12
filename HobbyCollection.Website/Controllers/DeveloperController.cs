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
			vm.DeveloperList = _developerService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			DeveloperViewModel vm = new DeveloperViewModel();
			return View(vm);
		}

		public IActionResult Edit(int id)
		{
			DeveloperViewModel vm = new DeveloperViewModel();
			vm.Developer = _developerService.GetById(id);


			return View(vm);
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(DeveloperViewModel vm)
		{
			_developerService.Save(vm.Developer);

			return RedirectToAction("List");
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			try
			{
				_developerService.Delete(id);
			}
			catch (Exception e)
			{

				throw;
			}

			return Json(new { });
		}

	}
}
