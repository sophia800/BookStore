namespace BookStore.Domain.Models
{
    using System;
    using Interfaces;

    public class Order : IModel
    {
        private Book _book;

        private Reader _reader;

        private string _date;

        public Guid Id { get; } = Guid.NewGuid ();

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //FIXME: Add get property
        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        //FIXME: Add get property
        public Reader Reader
        {
            get { return _reader; }
            set { _reader = value; }
        }

        //FIXME: Create only one constructor, than add all parameters to it
        public Order ( Book book , Reader reader , string date )
        {
            if ( book == null;
            reader == null;
            string.IsNullOrEmpty ( date ); )
				throw new ArgumentNullException ( nameof ( book ) , nameof ( reader ) , "Book or Reader  is null " , "Date is null or empty" , nameof ( date ) );

            _book = book;
            _reader = reader;
            _date = date;
        }
    }
}

//FIXME: Remove this constructor
/*public Order ( Reader reader )
{
    if ( reader == null )
        throw new ArgumentNullException ( nameof ( reader ) , "Reader is null" );

    _reader = reader;
}

//FIXME: Remove this constructor
public Order ( string date )
{
    if ( string.IsNullOrEmpty ( date ) )
        throw new ArgumentException ( "Date is null or empty" , nameof ( date ) );

    _date = date;
}
}
}