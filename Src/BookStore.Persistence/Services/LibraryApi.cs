namespace BookStore.Persistence.Services
{
	using System.Collections.Generic;
	using System.Linq;
	using UnitOfWork.Interfaces;
	using Domain.Models;

	public sealed class LibraryApi
	{
		private readonly IUnitOfWork _unitOfWork;

		public IEnumerable<Author> Authors { get; } = Enumerable.Empty<Author> ();

		public IEnumerable<Book> Books { get; } = Enumerable.Empty<Book> ();

		public IEnumerable<Order> Orders { get; } = Enumerable.Empty<Order> ();

		public IEnumerable<Reader> Readers { get; } = Enumerable.Empty<Reader> ();

		public LibraryApi ( IUnitOfWork unitOfWork )
		{
			_unitOfWork = unitOfWork;

			Load ();
		}

		public void Save ()
		{

		}

		private void Load ()
		{

		}
	}
}