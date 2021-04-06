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


			Book book = new Book ();

			book.SetAuthor ( "some name" , "some bio" );


			Reader reader = new Reader ();

			reader.SetName ( "some name" );

			reader.SetEmail ( "some email" );

			reader.SetCity ( "some city" );

			reader.SetStreet ( "some street" );

			reader.SetHouse ( "some house" );


			Order order = new Order ();

			order.SetBook ( "some book" );

			order.SetReader ( "some name" , "some email" , "some city" , "some street" , "some house" );

			order.SetDate ( "some date" );


			System.Console.WriteLine ( "All work" );
		}
	}
}