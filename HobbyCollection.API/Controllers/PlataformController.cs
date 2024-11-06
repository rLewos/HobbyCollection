using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlataformController : BaseController
	{
        private readonly IPlataformService _plataformService;

        public PlataformController(IPlataformService plataformService)
        {
            _plataformService = plataformService;
        }

        [HttpPost("Save")]
        public IActionResult Save(PlataformDTO plataformDTO)
        {


            return Ok();
        }
    }
}
