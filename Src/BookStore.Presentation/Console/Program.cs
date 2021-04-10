namespace BookStore.Presentation.Console
{
	using System;
	using Domain.Models;

	public static class Program
	{
		public static void Main ()
		{
			Author author = new Author ( "some name" )
			{
				Biography = "some bio"
			};
		}
	}
}