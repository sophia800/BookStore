namespace BookStore.Domain.Models
{
    using System;
    using Interfaces;

    public class Book : IModel
    {
        private Author _author;

        private string _title;

        public Guid Id { get; } = Guid.NewGuid ();

        public Author Author
        {
            get => _author;
            set => _author = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public Book ()
        { }

        public Book ( string title , Author author )
        {
            if ( string.IsNullOrEmpty ( title ) )
                throw new ArgumentException ( "Title is null or empty" , nameof ( title ) );

            if ( author is null )
                throw new ArgumentNullException ( nameof ( author ) , "Author is null" );

            _author = author;
            _title = title;
        }
    }
}