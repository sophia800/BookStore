namespace BookStore.Domain.Models
{
    using System;
    using Interfaces;

    public class Order : IModel
    {
        private Book _book;

        private Reader _reader;

        private string _date; //2020-01-23

        public Guid Id { get; } = Guid.NewGuid ();

        public string Date
        {
            get => _date;
            set => _date = value;
        }

        public Book Book
        {
            get => _book;
            set => _book = value;
        }

        public Reader Reader
        {
            get => _reader;
            set => _reader = value;
        }

        public Order ()
        { }

        public Order ( Book book , Reader reader , string date )
        {
            if ( book is null )
                throw new ArgumentNullException ( nameof ( book ) , "Book is null" );

            if ( reader is null )
                throw new ArgumentNullException ( nameof ( reader ) , "Reader is null" );

            if ( string.IsNullOrEmpty ( date ) )
                throw new ArgumentException ( "Date is null or empty" , nameof ( date ) );

            _book = book;
            _reader = reader;
            _date = date;
        }
    }
}