﻿namespace BookStore.Application.Dtos
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public sealed record BookDto
	{
		public Guid BookId { get; init; }

		public IEnumerable<Guid> ReadersId { get; init; } = Enumerable.Empty<Guid> ();
	}
}