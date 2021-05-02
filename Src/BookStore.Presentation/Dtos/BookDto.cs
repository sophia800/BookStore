using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Presentation.Dtos
{
    public sealed record BookDto
    {
        public Guid BookId { get; init; }

        public IEnumerable<Guid> ReadersId { get; init; } = Enumerable.Empty<Guid> ();
    }
}