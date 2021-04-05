namespace BookStore.Domain.Models
{
    public class Order
    {
        private Book _book;

        public void SetBook ( string Author )
        {
            _book = new Book ();

            _book.SetAuthor ( Author );
        }

        private Reader _reader;
        public void SetReader ( string name, string email, string city, string street, string house )
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
