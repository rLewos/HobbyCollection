using Games.Repository;
using Games.Repository.Interfaces;
using Games.Service;
using Games.Service.Interfaces;
using Hobby.Repository;
using Hobby.Repository.Interfaces;
using Hobby.Service;
using Hobby.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HobbyCollection.Website
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
			_services.AddTransient<IGameService, GameService>();
			_services.AddTransient<IGameRepository, GameRepository>();

			_services.AddTransient<IUserService, UserService>();
			_services.AddTransient<IUserRepository, UserRepository>();

			_services.AddTransient<IDeveloperService, DeveloperService>();
			_services.AddTransient<IDeveloperRepository, DeveloperRepository>();

			_services.AddTransient<IPublisherService, PublisherService>();
			_services.AddTransient<IPublisherRepository, PublisherRepository>();

			_services.AddTransient<IPlataformService, PlataformService>();
			_services.AddTransient<IPlataformRepository, PlataformRepository>();
		}
    }
}
