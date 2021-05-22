namespace BookStore.Infostructure.loC.DependencyInjections
{
	using Application.Services.OrderServices;
	using Application.Services.BookServices;
	using Persistence.Context;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;

	public static class InjectorBootStrapper
	{
		public static void InjectLayersDependency ( this IServiceCollection services , IConfiguration _ )
		{
			services.AddDbContext<LibraryContext> ();

			services.AddScoped<OrderService> ();

			services.AddScoped<BookService> ();
		}
	}
}