namespace BookStore.Domain.Models
{
	public class Order
	{
		private Book _book;
        
        private Reader _reader;

		private string _date;

		public void SetBook ( string author )
		{
			_book = new Book ();

			_book.SetAuthor ( "some name" , author );
		}
		
        public void SetReader ( string name , string email , string city , string street , string house )
		{
			_reader = new Reader ();

			_reader.SetName ( name );
			_reader.SetEmail ( email );
			_reader.SetCity ( city );
			_reader.SetStreet ( street );
			_reader.SetHouse ( house );
		}
	}
}
