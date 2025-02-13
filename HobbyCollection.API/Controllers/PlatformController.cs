using AutoMapper;
using Games.Model;
using Hobby.Model.DTO;
using Hobby.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HobbyCollection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    [Authorize(Roles = "Manager")]
	public class PlatformController : BaseController
	{
        private readonly IMapper _mapper;
        private readonly IPlatformService _iPlatformService;

        public PlatformController(IMapper mapper, IPlatformService iPlatformService)
        {
            _mapper = mapper;
            _iPlatformService = iPlatformService;
        }

        [HttpPost("Save")]
        public IActionResult Save([FromBody] PlatformDTO platformDto)
        {
            try
            {
				Platform platform = _mapper.Map<Platform>(platformDto);
				_iPlatformService.Save(platform);

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
            IList<Platform> plataformList = _iPlatformService.ListAll();
            IList<PlatformDTO> plataformDTOList = _mapper.Map<IList<PlatformDTO>>(plataformList);
            
            return Ok(plataformDTOList);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            Platform platform = _iPlatformService.GetById(id);
            PlatformDTO platformDto = _mapper.Map<PlatformDTO>(platform);
            
            return Ok(platformDto);
        }
        
        
    }
}
