using AutoMapper;
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
		//private readonly IMapper _mapper;
		private readonly IGameService _gameService;

        public GameController(/*IMapper mapper,*/ IGameService gameService) {
			//_mapper = mapper;
			_gameService = gameService;
		}

        [HttpGet("GetById")]
        public IActionResult  GetById(int id)
        {
            GameDTO gameDTO = new GameDTO();
            gameDTO.Id = 1;
			gameDTO.Name = "NieR: Automata";



			return Ok(gameDTO);
        }

        [HttpPost("Save")]
        public IActionResult Save(GameDTO game)
        {
            Debug.WriteLine(game.Name);
			//_gameService.Save();

			return Ok();
        }

		[HttpGet("List")]
		public IList<GameDTO> List()
        {
            IList<GameDTO> gameDTOList = new List<GameDTO>();
			
            GameDTO gameDTO = new GameDTO();
			gameDTO.Id = 1;
			gameDTO.Name = "NieR: Automata";

			gameDTOList.Add(gameDTO);

			GameDTO gameDTO2 = new GameDTO();
			gameDTO.Id = 2;
			gameDTO.Name = "Hatsune Miku: Project DIVA Future Tone DX";

            gameDTOList.Add(gameDTO2);
			var list = _gameService.ListAll();


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
