using AutoMapper;
using Games.Model;
using Games.Service.Interfaces;
using Hobby.Model.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

        [HttpGet("GetById")]
        public IActionResult  GetById(int id)
        {
			Game game = _gameService.GetById(id);
			GameDTO gameDTO = _mapper.Map<GameDTO>(game);

			return Ok(gameDTO);
        }

        [HttpPost("Save")]
        public IActionResult Save(GameDTO gameDTO)
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
		public IList<GameDTO> List()
        {
  			IList<Game> gameList = _gameService.ListAll();
			IList<GameDTO> gameDTOList = _mapper.Map<IList<GameDTO>>(gameList);

			return gameDTOList;
        }

		[HttpGet("ListAll")]
        public async Task<IList<GameDTO>> ListAllAsync()
        {
			IList<GameDTO> gameDTOList = new List<GameDTO>();

            await Task.Run(() => {
				GameDTO gameDTO = new GameDTO();
				gameDTO.Id = 1;
				gameDTO.Name = "NieR: Automata";

				gameDTOList.Add(gameDTO);

				GameDTO gameDTO2 = new GameDTO();
				gameDTO.Id = 2;
				gameDTO.Name = "Hatsune Miku: Project DIVA Future Tone DX";

				gameDTOList.Add(gameDTO2);
			});

            return gameDTOList;
        }
    }
}
