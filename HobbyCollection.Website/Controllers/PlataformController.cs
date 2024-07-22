using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class PlataformController : Controller
	{
        public PlataformController()
        {
            
        }

        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			return View();
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save()
		{
			return RedirectToAction("List");
		}
	}
}
