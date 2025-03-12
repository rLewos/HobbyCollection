using Games.Repository;
using Games.Repository.Interfaces;
using Games.Service;
using Games.Service.Interfaces;
using Hobby.Repository;
using Hobby.Repository.Interfaces;
using Hobby.Service;
using Hobby.Service.Interfaces;

namespace Hobby.Infraestructure
{
	public class InjectionDependeceMapping
	{
        private readonly IServiceCollection _services;

        public InjectionDependeceMapping(IServiceCollection serviceDescriptor)
        {
            this._services = serviceDescriptor;
        }

        public void Init()
        {
			SetServices();
			SetRepositories();
			
			_services.AddScoped<ITokenGenerator, TokenGenerator>();
		}

        private void SetServices()
        {
	        _services.AddScoped<IGameService, GameService>();
	        _services.AddScoped<IUserService, UserService>();
	        _services.AddScoped<IDeveloperService, DeveloperService>();
	        _services.AddScoped<IPublisherService, PublisherService>();
	        _services.AddScoped<IPlatformService, PlatformService>();
	        _services.AddScoped<IUserGameService, UserGameService>();
        }

        private void SetRepositories()
        {
	        _services.AddScoped<IGameRepository, GameRepository>();
	        _services.AddScoped<IUserRepository, UserRepository>();
			_services.AddScoped<IDeveloperRepository, DeveloperRepository>();
			_services.AddScoped<IPublisherRepository, PublisherRepository>();
			_services.AddScoped<IPlatformRepository, PlatformRepository>();
			_services.AddScoped<IUserGameRepository, UserGameRepository>();
        }
    }
}
