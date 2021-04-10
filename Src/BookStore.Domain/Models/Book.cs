using System;

namespace BookStore.Domain.Models
{
    public class Book
    {
        private Author _author;

        private string _title;

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
        }
    }
}