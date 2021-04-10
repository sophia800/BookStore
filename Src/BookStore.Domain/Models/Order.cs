using System;

namespace BookStore.Domain.Models
{
	public class Order
	{
		private Book _book;

		private Reader _reader;

		private string _date;

		public Order ( Book book )
		{
			if ( book == null )
				throw new ArgumentNullException ( nameof ( book ) , "Book is null" );

			_book = book;
		}

		public void SetDate ( string date )
		{
			_date = date;
		}

		public string GetDate ()
		{
			return _date;
		}

		public void SetBook ( Book book )
		{
			_book = book;
		}

		public void SetReader ( Reader reader )
		{
			_reader = reader;
		}
	}
}
