using AutoMapper;
using Games.Model;
using Hobby.Model.DTO;

namespace HobbyCollection.API
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
			CreateMap<Game, GameDTO>().ReverseMap();
			CreateMap<Developer, DeveloperDTO>().ReverseMap();
			CreateMap<User, UserDTO>().ReverseMap();
			CreateMap<Platform, PlatformDTO>().ReverseMap();
			CreateMap<Publisher, PublisherDTO>().ReverseMap();
		}
    }
}
