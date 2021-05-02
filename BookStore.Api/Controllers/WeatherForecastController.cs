namespace BookStore.Api.Controllers
{
	using BookStore.Application.Dtos;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Logging;

	[ApiController]
	[Route ( "[controller]" )]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController ( ILogger<WeatherForecastController> logger )
		{
			_logger = logger;
		}

		//https://docs.microsoft.com/uk-ua/dotnet/standard/components?v=someValue

		[HttpGet ( "{ukUa}/{dotnet}/{standard}/{components}" )]
		public IActionResult Get ( [FromQuery] string v ,

								   [FromRoute] string ukUa ,
								   [FromRoute] string dotnet ,
								   [FromRoute] string standard ,
								   [FromRoute] string components )
		{
			return Ok ();
		}

		[HttpPost]
		public IActionResult Post ( [FromBody] BookDto book )
		{
			_logger.LogInformation ( "Its `Post` message" );

			return Ok ( book );
		}

		[HttpPut]
		public IActionResult Put ()
		{
			_logger.LogInformation ( "Its `Put` message" );

			return NoContent ();
		}

		[HttpPatch]
		public IActionResult Patch ()
		{
			_logger.LogInformation ( "Its `Patch` message" );

			return NoContent ();
		}

		[HttpDelete]
		public IActionResult Delete ()
		{
			_logger.LogInformation ( "Its `Delete` message" );

			return NoContent ();
		}

		[HttpHead]
		public IActionResult Head ()
		{
			_logger.LogInformation ( "Its `Delete` message" );

			return NoContent ();
		}

		[HttpOptions]
		public IActionResult Options ()
		{
			_logger.LogInformation ( "Its `Delete` message" );

			return NoContent ();
		}
	}
}