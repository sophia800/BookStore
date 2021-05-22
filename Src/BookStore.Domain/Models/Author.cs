namespace BookStore.Domain.Models
{
	using System.Collections.Generic;
	using Interfaces;

	public sealed class Author : BaseModel, IPerson
	{
		public string Name { get; set; }

		public string Biography { get; set; }

		public HashSet<Book> Books { get; set; } = new ();
	}
}