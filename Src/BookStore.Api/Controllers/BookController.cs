namespace BookStore.Api.Controllers
{
	using System.Threading.Tasks;
	using BookStore.Application.Services.BookServices;
	using BookStore.Application.Services.OrderServices;
	using BookStore.Domain.Models;
	using Interfaces;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Logging;

	public sealed class BookController : ExtendedController
	{
		private readonly BookService _bookService;

		public BookController ( BookService bookService )
		{
			_bookService = bookService;
		}

		[HttpPost]
		public async Task<IActionResult> CreateBook ( [FromQuery] string title )
		{
			return Ok ( await _bookService.CreateBookAsync ( title ) );
		}

		[HttpGet]
		public async Task<IActionResult> GetBooks ()
		{
			return Ok ( await _bookService.GetBooksAsync () );
		}
	}
}