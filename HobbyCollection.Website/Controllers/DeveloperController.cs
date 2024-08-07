﻿using HobbyCollection.Website.ViewModels;
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

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Save(DeveloperViewModel vm)
		{


			return RedirectToAction("List");
		}


	}
}
