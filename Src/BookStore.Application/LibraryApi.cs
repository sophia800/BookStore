namespace BookStore.Application
{
	using Domain.Models;
	using BookStore.Persistence.UnitOfWork.Interfaces;
	using System.Collections.Generic;

	public sealed class LibraryApi
	{
		private readonly IUnitOfWork _unitOfWork;

		public List<Author> Authors { get; private set; } = new List<Author> ();

		public List<Book> Books { get; private set; } = new List<Book> ();

		public List<Order> Orders { get; private set; } = new List<Order> ();

		public List<Reader> Readers { get; private set; } = new List<Reader> ();

		public LibraryApi ( IUnitOfWork unitOfWork )
		{
			_unitOfWork = unitOfWork;

			Load ();
		}

		private void Load ()
		{
			Authors = _unitOfWork.Repository<Author> ()
				.GetAll ();

			Books = _unitOfWork.Repository<Book> ()
				.GetAll ();

			Orders = _unitOfWork.Repository<Order> ()
				 .GetAll ();

			Readers = _unitOfWork.Repository<Reader> ()
				.GetAll ();
		}

		public void Save ()
		{
			_unitOfWork.Repository<Author> ()
				.Commit ( Authors );

			_unitOfWork.Repository<Book> ()
				.Commit ( Books );

			_unitOfWork.Repository<Order> ()
				 .Commit ( Orders );

			_unitOfWork.Repository<Reader> ()
				.Commit ( Readers );
		}
	}
}