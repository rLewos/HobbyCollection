using Games.Model;
using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[AllowAnonymous]
	public class AuthController(ITokenGenerator tokenGenerator) : BaseController
	{
		[HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO user)
        {
			TokenDTO dto = new TokenDTO();
			dto.Token = tokenGenerator.GenerateToken(user);
			
			return Ok(dto);
        }
    }
}
