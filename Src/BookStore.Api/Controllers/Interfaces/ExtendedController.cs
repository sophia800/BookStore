using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers.Interfaces
{
	[ApiController]
	[Route ( "[controller]" )]
	public abstract class ExtendedController : ControllerBase
	{
	}
}