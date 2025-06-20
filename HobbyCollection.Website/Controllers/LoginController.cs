using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}