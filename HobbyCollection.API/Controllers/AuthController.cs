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
        public string Login(LoginDTO user)
        {
			string token = _tokenGenerator.GenerateToken(user);
            return token;
        }

    }
}
