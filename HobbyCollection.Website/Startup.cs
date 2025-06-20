using Games.Infraestructure;
using HobbyCollection.Website.Service;
using Microsoft.EntityFrameworkCore;

namespace HobbyCollection.Website
{
	public static class Startup
	{
        public static void Initialize(this IServiceCollection services)
        {
			services.AddServices();
		}

        private static void AddServices(this IServiceCollection services)
        {
	        services.AddTransient<IPlatformService, PlatformService>();
        }
    }
}
