namespace BookStore.Presentation.Console
{
    using Domain.Models;

    public class Program
    {
        public static void Main ()
        {
            Author author = new Author ();

            author.SetName ( "some name" );

            author.SetBiography ( "some bio" );
        }
    }
}