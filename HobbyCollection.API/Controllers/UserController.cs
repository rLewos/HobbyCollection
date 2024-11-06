using AutoMapper;
using Games.Model;
using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : BaseController
	{
        private readonly IUserService _userService;
		private readonly IMapper _mapper;

        public UserController(IMapper mapper, IUserService userService)
        {
			_mapper = mapper;
            _userService = userService;
        }

		[HttpPost("Save")]
		public IActionResult Save(UserDTO userDTO)
		{
			User user = _mapper.Map<User>(userDTO);
			_userService.Save(user);

			return Ok();
		}
	}
}
