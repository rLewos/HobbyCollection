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
	public class AuthController : BaseController
	{
        private readonly ITokenGenerator _tokenGenerator;

		public AuthController(ITokenGenerator tokenGenerator)
		{
			_tokenGenerator = tokenGenerator;
		}

		[HttpPost("Login")]
        public TokenDTO Login(LoginDTO user)
        {
			TokenDTO dto = new TokenDTO();
			dto.Token = _tokenGenerator.GenerateToken(user);
			
			return dto;
        }

    }
}
