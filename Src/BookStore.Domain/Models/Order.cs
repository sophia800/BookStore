using System;

namespace BookStore.Domain.Models
{
    public class Order
    {
        private Book _book;

        private Reader _reader;

        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Book Book
        {
            set { _book = value; }
        }

        public Reader Reader
        {
            set { _reader = value; }
        }

        public Order ( Book book )
        {
            if ( book == null )
                throw new ArgumentNullException ( nameof ( book ) , "Book is null" );

            _book = book;
        }

        public Order ( Reader reader )
        {
            if ( reader == null )
                throw new ArgumentNullException ( nameof ( reader ) , "Reader is null" );

            _reader = reader;
        }

        public Order ( string date )
        {
            if ( string.IsNullOrEmpty ( date ) )
                throw new ArgumentException ( "Date is null or empty" , nameof ( date ) );

            _date = date;
        }
    }
}