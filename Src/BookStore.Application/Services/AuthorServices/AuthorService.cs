namespace BookStore.Application.Services.BookServices
{
    using Domain.Models;
    using Persistence.Context;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public sealed class AuthorService
    {
        private readonly LibraryContext _libraryContext;

        public AuthorService ( LibraryContext libraryContext )
        {
            _libraryContext = libraryContext;
        }

        public async Task<Author> CreateAuthorAsync ( string name , string biography , CancellationToken cancellationToken = default )
        {
            var authorEntry =
                await _libraryContext.Authors.AddAsync ( new () { Name = name , Biography = biography } , cancellationToken );

            await _libraryContext.SaveChangesAsync ( cancellationToken );

            return authorEntry.Entity;
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync ( CancellationToken cancellationToken = default ) =>
            await _libraryContext.Authors.ToListAsync ( cancellationToken );
    }
}