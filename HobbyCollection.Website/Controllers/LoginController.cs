using HobbyCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.Website.Controllers;

public class LoginController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        
        return RedirectToAction("Index","Home");
    }
}