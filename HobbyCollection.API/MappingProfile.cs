using AutoMapper;
using Games.Model;
using Hobby.Model.DTO;

namespace HobbyCollection.API
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
			// Entity -> DTO
			CreateMap<Game, GameDTO>();
			CreateMap<Developer, DeveloperDTO>();
			CreateMap<User, UserDTO>();
			CreateMap<Plataform, PlataformDTO>();
			CreateMap<Publisher, PublisherDTO>();

			// DTO -> Entity
			CreateMap<GameDTO, Game>();
			CreateMap<DeveloperDTO, Developer>();
			CreateMap<UserDTO, User>();
			CreateMap<PlataformDTO, Plataform>();
			CreateMap<PublisherDTO, Publisher>();
		}
    }
}
