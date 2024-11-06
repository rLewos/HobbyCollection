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
	public class PublisherController : BaseController
	{
		private readonly IPublisherService _publisherService;
		private readonly IMapper _mapper;

		public PublisherController(IMapper mapper, IPublisherService publisherService)
		{
			_publisherService = publisherService;
			_mapper = mapper;
		}

		[HttpPost("Save")]
		public IActionResult Save(PublisherDTO publisherDTO)
		{


			return Ok();
		}

		[HttpGet("GetById")]
		public IActionResult GetById(int id)
		{


			return Ok();
		}

		[HttpGet("List")]
		public IActionResult List()
		{
			IList<Publisher> publisherList = _publisherService.ListAll();
			IList<PublisherDTO> dto = _mapper.Map<IList<PublisherDTO>>(publisherList);

			return Ok(dto);
		}
	}
}