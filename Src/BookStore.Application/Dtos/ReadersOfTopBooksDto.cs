namespace BookStore.Application.Dtos
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public record ReadersOfTopBooksDto
	{
		public Guid ReaderId { get; set; }

		public IEnumerable<Guid> TopBooks { get; set; } = Enumerable.Empty<Guid> ();
	}
}