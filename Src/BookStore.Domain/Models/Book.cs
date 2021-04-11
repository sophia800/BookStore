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
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //TODO: Finish me
        public Book ( string title )
        {
            if ( string.IsNullOrEmpty ( title ) )
                throw new ArgumentException ( "Title is null or empty" , nameof ( title ) );
            _title = title;
        }
    }
}