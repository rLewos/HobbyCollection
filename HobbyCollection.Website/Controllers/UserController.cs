﻿using Games.Model;
using Hobby.Service.Interfaces;
using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public class UserController : BaseController
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			this._userService = userService;
		}

		#region Views

		public IActionResult Index()
		{
			return RedirectToAction("List");
		}

		public IActionResult List()
		{
			UserViewModel vm = new UserViewModel();
			vm.UserList = _userService.ListAll();

			return View(vm);
		}

		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Edit(int id) {

			UserViewModel vm = new UserViewModel();
			vm.User = _userService.GetById(id);

			return View("Add", vm);
		}

		#endregion

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(UserViewModel vm)
		{
			try
			{
				_userService.Save(vm.User);
			}
			catch (Exception e)
			{
				return this.Json(false, "User couldn't be saved." );
			}

			return this.Json(true, "User has been saved successfully.");
		}
	}
}
