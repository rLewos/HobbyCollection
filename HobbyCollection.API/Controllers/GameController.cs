using System.Security.Claims;
using AutoMapper;
using Games.Model;
using Games.Service.Interfaces;
using Hobby.Model.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    [Authorize(Roles = "Manager")]
	public class GameController : BaseController
	{
		private readonly IMapper _mapper;
		private readonly IGameService _gameService;
		
        public GameController(IMapper mapper, IGameService gameService) 
		{
			_mapper = mapper;
			_gameService = gameService;
		}

        [HttpGet("GetById/{id}")]
        public IActionResult  GetById(int id)
        {
			Game game = _gameService.GetById(id);
			GameDTO gameDTO = _mapper.Map<GameDTO>(game);

			return Ok(gameDTO);
        }

        [HttpPost("Save")]
        public IActionResult Save([FromBody] GameDTO gameDTO)
        {
			try
			{
				Game game = _mapper.Map<Game>(gameDTO);
				_gameService.Save(game);

				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
        }

		[HttpGet("List")]
		public IActionResult List()
        {
  			IList<Game> gameList = _gameService.ListAll();
			IList<GameDTO> gameDTOList = _mapper.Map<IList<GameDTO>>(gameList);

			return Ok(gameDTOList);
        }
		
		[HttpGet("ListByUser")]
		public IActionResult ListByUser()
		{
			string? userId = User?.FindFirstValue("UserId");
			if (userId == null)
				return BadRequest();
			
			var gameList = _gameService.ListByUserId(userId);
			var gameDtoList = _mapper.Map<IList<GameDTO>>(gameList);
			
			return Ok(gameDtoList);
		}
    }
}
