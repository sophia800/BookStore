namespace BookStore.Presentation.Console
{
    using System.Collections.Generic;
    using System.Linq;
    using Application;
    using Dtos;
    using Domain.Models;

    public sealed class LibraryApiDecorator
    {
        private readonly LibraryApi _libraryApi;

        public LibraryApiDecorator ( LibraryApi libraryApi )
        {
            _libraryApi = libraryApi;
        }

        public void Examples ()
        {
            //! Grouping

            //var orders =
            //	new[]
            //	{
            //		new { UserId = "691bff0a-3b31-4d59-8454-a7e9a7e4eaf6", ProductId = "9e1b6bfe-5f03-47e6-8a9f-5faff4dce0eb" },
            //		new { UserId = "691bff0a-3b31-4d59-8454-a7e9a7e4eaf6", ProductId = "12346bfe-5f03-47e6-8a9f-5faff4dce0eb" },
            //		new { UserId = "691bff0a-3b31-4d59-8454-a7e9a7e4eaf6", ProductId = "131b6bfe-5f03-47e6-1212-5faff4dce0eb" },
            //		new { UserId = "691bff0a-3b31-4d59-8454-a7e9a7e4eaf6", ProductId = "11111111-3213-47e6-8a9f-5faff4dce0eb" },
            //
            //		new { UserId = "11123123-3b31-4d59-8454-a7e9a7e4eaf6", ProductId = "9e1b6bfe-5f03-47e6-8a9f-5faff4dce0eb" },
            //	};
            //
            //var groupable = orders
            //	.GroupBy ( customer => customer.UserId )
            //
            //	.Select ( gropableOrderCustomers =>
            //		new
            //		{
            //			CusomerId = gropableOrderCustomers.Key ,
            //
            //			ProductsId = gropableOrderCustomers.Select ( gropableOrderCustomer => gropableOrderCustomer.ProductId )
            //		} );

            //! Sorting

            //var products =
            //	new[]
            //	{
            //		new { Product = "Apple", Price = 12 , Weight = 123 } ,
            //		new { Product = "Orange", Price = 4 , Weight = 22 } ,
            //		new { Product = "Banana", Price = 14 , Weight = 23 } ,
            //		new { Product = "Milk", Price = 32 , Weight = 12 }
            //	};
            //
            //var sortableProducts =
            //	products.OrderByDescending ( product => product.Price );
        }

        public IEnumerable<object> GetTopBooks ( int limit = 1 ) =>
          _libraryApi.Orders
           .GroupBy ( order => order.Book.Id )

                .OrderByDescending ( gropableOrders => gropableOrders.Count () )

                .Select ( gropableOrders =>
                    new
                    {
                        BookId = gropableOrders.Key ,

                        ReadersId = gropableOrders.Select ( order => order.Reader.Id )
                    } )

                .Take ( count: limit );

        public IEnumerable<ReaderDto> GetTopReaders ( int limit = 1 ) =>
            _libraryApi.Orders
                .GroupBy ( order => order.Reader.Id )

                .OrderByDescending ( gropableOrders => gropableOrders.Count () )

                .Select ( gropableOrders =>
                    new ReaderDto
                    {
                        ReaderId = gropableOrders.Key ,

                        BooksId = gropableOrders.Select ( order => order.Book.Id )
                    } )

                .Take ( count: limit );

        public IEnumerable<Reader> GetReadersOfMostPopularBook ( int limit = 3 ) =>
         _libraryApi.Readers;
    }
}