namespace BookStore.Presentation.Console
{
	using BookStore.Domain.Models;
	using BookStore.Persistence.Services;
	using BookStore.Persistence.UnitOfWork;

	public static class Program
	{
		public static void Main ()
		{
			var data = new DataBaseManager ();

			var unitOfWork = new InMemoryUnitOfWork ( data );

			var test = unitOfWork.Repository<Author> ()
				.GetAll ();
		}
	}
}