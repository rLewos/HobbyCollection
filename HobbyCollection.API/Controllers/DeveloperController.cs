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
	public class DeveloperController : BaseController
	{
		private readonly IDeveloperService _developerService;
		private readonly IMapper _mapper;

		public DeveloperController(IMapper mapper, IDeveloperService developerService)
		{
			_mapper = mapper;
			_developerService = developerService;
		}

		[HttpPost("Save")]
		public IActionResult Save([FromBody] DeveloperDTO developerDTO)
		{
			try
			{
				Developer developer = _mapper.Map<Developer>(developerDTO);
				_developerService.Save(developer);

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
			Developer developer = _developerService.GetById(id);
			DeveloperDTO developerDTO = _mapper.Map<DeveloperDTO>(developer);

			return Ok(developerDTO);
		}

		[HttpGet("List")]
		public IActionResult List()
		{
			IList<Developer> developerList = _developerService.ListAll();
			IList<DeveloperDTO> dto = _mapper.Map<IList<DeveloperDTO>>(developerList);

			return Ok(dto);
		}
	}
}
