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
	public class PlataformController : BaseController
	{
        private readonly IMapper _mapper;
        private readonly IPlataformService _plataformService;

        public PlataformController(IMapper mapper, IPlataformService plataformService)
        {
            _mapper = mapper;
            _plataformService = plataformService;
        }

        [HttpPost("Save")]
        public IActionResult Save(PlataformDTO plataformDTO)
        {
            try
            {
				Plataform plataform = _mapper.Map<Plataform>(plataformDTO);
				_plataformService.Save(plataform);

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
            IList<Plataform> plataformList = _plataformService.ListAll();
            IList<PlataformDTO> plataformDTOList = _mapper.Map<IList<PlataformDTO>>(plataformList);
            return Ok(plataformDTOList);
        }

    }
}
