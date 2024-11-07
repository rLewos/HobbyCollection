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
			try
			{
				Publisher publisher = _mapper.Map<Publisher>(publisherDTO);
				_publisherService.Save(publisher);

				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpGet("GetById")]
		public IActionResult GetById(int id)
		{
			Publisher publisher = _publisherService.GetById(id);
			PublisherDTO publisherDTO = _mapper.Map<PublisherDTO>(publisher);

			return Ok(publisherDTO);
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