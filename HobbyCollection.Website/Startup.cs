namespace HobbyCollection.Website
{
	public static class InjectionDependeceMapping
	{
        public static void InitServicesRepositories(this IServiceCollection services)
        {
			services.AddTransient<IGameService, GameService>();
		}
    }
}
