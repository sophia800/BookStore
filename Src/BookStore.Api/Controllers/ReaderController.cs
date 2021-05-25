namespace BookStore.Api.Controllers
{
    using System.Threading.Tasks;
    using BookStore.Application.Services.BookServices;
    using BookStore.Application.Services.OrderServices;
    using BookStore.Domain.Models;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public sealed class ReaderController : ExtendedController
    {
        private readonly ReaderService _readerService;

        public ReaderController ( ReaderService readerService )
        {
            _readerService = readerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReader ( [FromQuery] string name , string email , string city , string house , string street )
        {
            return Ok ( await _readerService.CreateReaderAsync ( name , email , city , house , street ) );
        }

        [HttpGet]
        public async Task<IActionResult> GetReaders ()
        {
            return Ok ( await _readerService.GetReadersAsync () );
        }
    }
}