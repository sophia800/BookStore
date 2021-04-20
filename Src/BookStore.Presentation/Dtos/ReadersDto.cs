namespace BookStore.Presentation.Console.Dtos
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public sealed record ReadersDto
	{
		public Guid ReaderId { get; init; }

		public IEnumerable<Guid> BooksId { get; init; } = Enumerable.Empty<Guid> ();
	}
}