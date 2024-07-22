using Hobby.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameController : BaseController
	{
        public GameController()
        {
            
        }

        [HttpGet]
        public GameDTO Get(int id)
        {
            GameDTO gameDTO = new GameDTO();
            gameDTO.Id = 1;
			gameDTO.Name = "NieR: Automata";

			return gameDTO;
        }

        [HttpPost]
        public void Save(GameDTO game)
        {
            Debug.WriteLine(game.Name);
        }

		[HttpGet]
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

			return gameDTOList;
        }
    }
}
