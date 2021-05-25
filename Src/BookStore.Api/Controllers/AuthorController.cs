namespace BookStore.Api.Controllers
{
    using System.Threading.Tasks;
    using BookStore.Application.Services.BookServices;
    using BookStore.Application.Services.OrderServices;
    using BookStore.Domain.Models;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public sealed class AuthorController : ExtendedController
    {
        private readonly AuthorService _authorService;

        public AuthorController ( AuthorService authorService )
        {
            _authorService = authorService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor ( [FromQuery] string name , string biography )
        {
            return Ok ( await _authorService.CreateAuthorAsync ( name , biography ) );
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors ()
        {
            return Ok ( await _authorService.GetAuthorsAsync () );
        }
    }
}