using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class DeveloperController : Controller
	{
		public DeveloperController() { }

		#region Views

		public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List() { 
			return View();
		}

		public IActionResult Add() {
			return View();
		}

		#endregion
	}
}
