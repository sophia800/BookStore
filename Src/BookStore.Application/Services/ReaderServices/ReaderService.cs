namespace BookStore.Application.Services.BookServices
{
    using Domain.Models;
    using Persistence.Context;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public sealed class ReaderService
    {
        private readonly LibraryContext _libraryContext;

        public ReaderService ( LibraryContext libraryContext )
        {
            _libraryContext = libraryContext;
        }

        public async Task<Reader> CreateReaderAsync ( string name , string email , string city , string street , string house , CancellationToken cancellationToken = default )
        {
            var readerEntry =
                await _libraryContext.Readers.AddAsync ( new () { Name = name , Email = email , City = city , Street = street , House = house } , cancellationToken );

            await _libraryContext.SaveChangesAsync ( cancellationToken );

            return readerEntry.Entity;
        }

        public async Task<IEnumerable<Reader>> GetReadersAsync ( CancellationToken cancellationToken = default ) =>
            await _libraryContext.Readers.ToListAsync ( cancellationToken );
    }
}