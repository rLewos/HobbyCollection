using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DeveloperController : BaseController
	{
		private readonly IDeveloperService _developerService;

		public DeveloperController(IDeveloperService developerService)
		{
			_developerService = developerService;
		}

		[HttpPost("Save")]
		public IActionResult Save(DeveloperDTO developerDTO)
		{


			return Ok();
		}
	}
}
