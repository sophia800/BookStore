namespace BookStore.Persistence.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using UnitOfWork.Interfaces;
    using Domain.Models;

    public sealed class LibraryApi
    {
        private readonly IUnitOfWork _unitOfWork;

        public IEnumerable<Author> Authors { get; private set; } = Enumerable.Empty<Author> ();

        public IEnumerable<Book> Books { get; private set; } = Enumerable.Empty<Book> ();

        public IEnumerable<Order> Orders { get; private set; } = Enumerable.Empty<Order> ();

        public IEnumerable<Reader> Readers { get; private set; } = Enumerable.Empty<Reader> ();

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
            Authors = _unitOfWork.Repository<Author> ()
                .GetAll ();

            Books = _unitOfWork.Repository<Book> ()
                .GetAll ();
            Orders = _unitOfWork.Repository<Order> ()
                 .GetAll ();
            Readers = _unitOfWork.Repository<Reader> ()
                .GetAll ();
        }
    }
}