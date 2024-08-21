using Hobby.Service.Interfaces;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class PublisherController : BaseController
	{
		private readonly IPublisherService _publisherService;
		public PublisherController(IPublisherService publisherService)
        {
            this._publisherService = publisherService;
        }
        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			PublisherViewModel vm = new PublisherViewModel();

			return View(vm);
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
