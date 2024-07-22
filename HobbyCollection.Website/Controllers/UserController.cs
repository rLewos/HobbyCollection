using Games.Model;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class UserController : Controller
	{
        public static IList<User>? UserList { get; set; }

        public UserController()
        {
            
        }

        #region Views

        public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			UserViewModel vm = new UserViewModel();
			vm.UserList = UserList;

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(UserViewModel vm)
		{
			vm.User.Validate();
			UserList.Add(vm.User);

			return RedirectToAction("List");
		}
	}
}
