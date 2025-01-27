using AutoMapper;
using Games.Model;
using Hobby.Model.DTO;
using Hobby.Service;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = "Manager")]
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
		public IActionResult Save([FromBody] UserDTO userDTO)
		{
			try
			{
				User user = _mapper.Map<User>(userDTO);
				_userService.Save(user);

				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpGet("GetById/{id}")]
		public IActionResult GetById(int id)
		{
			User user = _userService.GetById(id);
			UserDTO userDTO = _mapper.Map<UserDTO>(user);

			return Ok(userDTO);
		}

		[HttpGet("List")]
		public IActionResult List()
		{
			IList<User> userList = _userService.ListAll();
			IList<UserDTO> dto = _mapper.Map<IList<UserDTO>>(userList);

			return Ok(dto);
		}
	}
}
