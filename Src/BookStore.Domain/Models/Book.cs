namespace BookStore.Domain.Models
{
    public class Book
    {
        private Author _author;

        public void SetAuthor ( string name, string biography )
        {
            _author = new Author ();

            _author.SetName ( name );

            _author.SetBiography ( biography );
        }
    }
}