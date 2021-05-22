namespace BookStore.Application.Services.OrderServices
{
	using Domain.Models;
	using Persistence.Context;
	using System.Threading.Tasks;
	using System.Threading;
	using System.Linq;
	using System.Collections.Generic;
	using Microsoft.EntityFrameworkCore;

	public sealed class OrderService
	{
		private readonly LibraryContext _libraryContext;

		public OrderService ( LibraryContext libraryContext )
		{
			_libraryContext = libraryContext;
		}

		// public IEnumerable<BookDto> GetTopBooks ( int limit = 1 ) =>
		// 	_libraryApi.Orders
		// 		.GroupBy ( order => order.Book.Id )

		// 		.OrderByDescending ( gropableOrders => gropableOrders.Count () )

		// 		.Select ( gropableOrders =>
		// 			new BookDto
		// 			{
		// 				BookId = gropableOrders.Key ,

		// 				ReadersId =
		// 					gropableOrders
		// 						.Select ( order => order.Reader.Id )
		// 						.Distinct ()
		// 			} )

		// 		.Take ( count: limit );

		// public IEnumerable<ReaderDto> GetTopReaders ( int limit = 1 ) =>
		// 	_libraryApi.Orders
		// 		.GroupBy ( order => order.Reader.Id )

		// 		.OrderByDescending ( gropableOrders => gropableOrders.Count () )

		// 		.Select ( gropableOrders =>
		// 			new ReaderDto
		// 			{
		// 				ReaderId = gropableOrders.Key ,

		// 				BooksId =
		// 					gropableOrders
		// 						.Select ( order => order.Book.Id )
		// 						.Distinct ()
		// 			} )

		// 		.Take ( count: limit );

		// public IEnumerable<Reader> GetReadersOfMostPopularBook ( int limit = 3 )
		// {
		// 	var topBooks = GetTopBooks ( limit );

		// 	var topReadersOfTopBooksIds =
		// 		topBooks
		// 			.Select ( topBook => topBook.ReadersId )
		// 			.SelectMany ( readersId => readersId )
		// 			.Distinct ();

		// 	return topReadersOfTopBooksIds
		// 		.Aggregate (
		// 			new Collection<Reader> () ,
		// 			( collection , readerId ) =>
		// 			  {
		// 				  var reader = _libraryApi.Readers.SingleOrDefault ( reader => reader.Id == readerId );

		// 				  collection.Add ( reader );

		// 				  return collection;
		// 			  } );
		// }
	}
}