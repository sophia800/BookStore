namespace BookStore.Persistence.Helpers
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using BookStore.Domain.Models.Interfaces;
	using Domain.Models;

	public static class Seeder
	{
		public static IEnumerable<IModel> SeededDataBase { get; } = SeedData ();

		private static IEnumerable<IModel> SeedData ()
		{
			var readers = SeedReaders ();

			var authors = SeedAuthors ();

			var books = SeedBooks ( authors );

			var orders = SeedOrders ( books , readers );

			var result = new List<IModel> ();

			result.AddRange ( readers );
			result.AddRange ( authors );
			result.AddRange ( books );
			result.AddRange ( orders );

			return result;
		}

		private static Collection<Reader> SeedReaders () =>
			new ()
			{
				new ()
				{
					Name = "Reader 1" ,
					Email = "Some email 1" ,
					City = "Some city 1" ,
					Street = "Some street 1" ,
					House = "Some house 1"
				} ,
				new ()
				{
					Name = "Reader 2" ,
					Email = "Some email 2" ,
					City = "Some city 2" ,
					Street = "Some street 2" ,
					House = "Some house 2"
				} ,
				new ()
				{
					Name = "Reader 3" ,
					Email = "Some email 3" ,
					City = "Some city 3" ,
					Street = "Some street 3" ,
					House = "Some house 3"
				} ,
				new ()
				{
					Name = "Reader 4" ,
					Email = "Some email 4" ,
					City = "Some city 4" ,
					Street = "Some street 4" ,
					House = "Some house 4"
				} ,
				new ()
				{
					Name = "Reader 5" ,
					Email = "Some email 5" ,
					City = "Some city 5" ,
					Street = "Some street 5" ,
					House = "Some house 5"
				}
			};

		private static Collection<Author> SeedAuthors () =>
			new ()
			{
				new ()
				{
					Name = "Some name 1" ,
					Biography = "some bio 1"
				} ,
				new ()
				{
					Name = "Some name 2" ,
					Biography = "some bio 2"
				} ,
				new ()
				{
					Name = "Some name 3" ,
					Biography = "some bio 3"
				} ,
				new ()
				{
					Name = "Some name 4" ,
					Biography = "some bio 4"
				}
			};

		private static Collection<Book> SeedBooks ( IEnumerable<Author> authors ) =>
			new ()
			{
				new ()
				{
					Author = authors.Single ( author => author.Name == "Some name 3" ) ,
					Title = "Some title 1"
				} ,
				new ()
				{
					Author = authors.Single ( author => author.Name == "Some name 3" ) ,
					Title = "Some title 2"
				} ,
				new ()
				{
					Author = authors.Single ( author => author.Name == "Some name 1" ) ,
					Title = "Some title 3"
				} ,
				new ()
				{
					Author = authors.Single ( author => author.Name == "Some name 4" ) ,
					Title = "Some title 4"
				} ,
				new ()
				{
					Author = authors.Single ( author => author.Name == "Some name 2" ) ,
					Title = "Some title 5"
				}
			};

		private static Collection<Order> SeedOrders ( IEnumerable<Book> books , IEnumerable<Reader> readers ) =>
			new ()
			{
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 1" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 1" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 2" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 1" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 3" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 1" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 4" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 2" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 4" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 3" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 5" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 4" )
				} ,
				new ()
				{
					Book = books.Single ( book => book.Title == "Some title 5" ) ,
					Reader = readers.Single ( reader => reader.Name == "Reader 5" )
				}
			};
	}
}