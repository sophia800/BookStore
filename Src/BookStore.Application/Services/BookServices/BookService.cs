namespace BookStore.Application.Services.BookServices
{
	using Domain.Models;
	using Persistence.Context;
	using System.Threading.Tasks;
	using System.Threading;
	using System.Collections.Generic;
	using Microsoft.EntityFrameworkCore;

	public sealed class BookService
	{
		private readonly LibraryContext _libraryContext;

		public BookService ( LibraryContext libraryContext )
		{
			_libraryContext = libraryContext;
		}

		public async Task<Book> CreateBookAsync ( string title , CancellationToken cancellationToken = default )
		{
			var bookEntry =
				await _libraryContext.Books.AddAsync ( new () { Title = title } , cancellationToken );

			await _libraryContext.SaveChangesAsync ( cancellationToken );

			return bookEntry.Entity;
		}

		public async Task<IEnumerable<Book>> GetBooksAsync ( CancellationToken cancellationToken = default ) =>
			await _libraryContext.Books.ToListAsync ( cancellationToken );
	}
}