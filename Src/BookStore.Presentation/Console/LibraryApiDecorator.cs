namespace BookStore.Presentation.Console
{
	using System.Collections.Generic;
	using Application;
	using Domain.Models;

	public sealed class LibraryApiDecorator
	{
		private readonly LibraryApi _libraryApi;

		public LibraryApiDecorator ( LibraryApi libraryApi )
		{
			_libraryApi = libraryApi;
		}

		public IEnumerable<Book> GetTopBooks ( int limit = 1 )
		{
			var booksReaders = _libraryApi.Books;

			return default;
		}

		public IEnumerable<Book> GetTopReaders ( int limit = 1 )
		{
			var readers = _libraryApi.Readers;

			return default;
		}

		public IEnumerable<Reader> GetReadersOfMostPopularBook ( int limit = 3 )
		{
			var readers = _libraryApi.Readers;

			return default;
		}
	}
}