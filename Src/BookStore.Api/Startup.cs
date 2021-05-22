namespace BookStore.Api
{
	using Domain.Models;
	using Infostructure.loC.DependencyInjections;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;
	using System;

	public sealed class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup ( IConfiguration configuration )
		{
			Configuration = configuration;
		}

		public void ConfigureServices ( IServiceCollection services )
		{
			services.AddControllers ();

			services.AddSwaggerGen ( swaggerGenOptions =>
			  {
				  swaggerGenOptions.SwaggerDoc ( "v1" , new () { Title = "BookStore.Api" , Version = "v1" } );
			  } );

			services.InjectLayersDependency ( Configuration );
		}

		public void Configure ( IApplicationBuilder applicationBuilder , IWebHostEnvironment webHostEnvironment )
		{
			if ( webHostEnvironment.IsDevelopment () )
			{
				applicationBuilder.UseDeveloperExceptionPage ();

				applicationBuilder.UseSwagger ();

				applicationBuilder.UseSwaggerUI ( swaggerUIOptions =>
				  {
					  swaggerUIOptions.RoutePrefix = string.Empty;

					  swaggerUIOptions.SwaggerEndpoint ( "/swagger/v1/swagger.json" , "BookStore.Api v1" );
				  } );
			}

			if ( webHostEnvironment.IsProduction () )
				applicationBuilder.UseHttpsRedirection ();

			applicationBuilder.UseRouting ();

			applicationBuilder.UseAuthorization ();

			applicationBuilder.UseEndpoints ( endpoints =>
			  {
				  endpoints.MapControllers ();
			  } );
		}
	}
}