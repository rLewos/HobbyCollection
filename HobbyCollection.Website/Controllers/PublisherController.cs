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
			vm.PublisherList = _publisherService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(PublisherViewModel vm)
		{
			try
			{
				_publisherService.Save(vm.Publisher);
			}
			catch (Exception e)
			{
				return this.Json(false, "Publisher couldn't be saved.");
			}

			return this.Json(true, "Publisher has been saved sucessfully.");
		}
	}
}
