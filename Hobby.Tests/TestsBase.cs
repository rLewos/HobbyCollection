using Games.Infraestructure;
using Games.Repository;
using Games.Repository.Interfaces;
using Games.Service;
using Games.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Tests
{
	public static class TestsBase
	{
		private static ServiceCollection services;

        private static IServiceProvider GetServiceProvider()
        {
			services = new ServiceCollection();
			services.AddTransient<IGameService, GameService>();
			services.AddTransient<IGameRepository, GameRepository>();
			services.AddDbContext<HobbyContext>(opt => opt.UseSqlServer("Server=localhost,1433;Database=HobbyInventory;User Id=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;"));

			ServiceProvider serviceProvider = services.BuildServiceProvider();

			return serviceProvider;
		}

		public static T GetService<T>()
		{
			return GetServiceProvider().GetRequiredService<T>();
		}
    }
}
