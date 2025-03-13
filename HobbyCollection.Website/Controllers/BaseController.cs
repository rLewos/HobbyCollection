using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers
{
	public abstract class BaseController : Controller
	{
		public BaseController() { }

		public IActionResult Json(bool success, string message)
		{
			if (!success) 
				Response.StatusCode = 500;

			return Json(new { message = message });
		}
	}
}
