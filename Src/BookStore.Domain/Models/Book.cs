namespace BookStore.Domain.Models
{
	using System.Collections.Generic;
	using Interfaces;

	public sealed class Book : BaseModel
	{
		public Author Author { get; set; }

		public string Title { get; set; }

		public HashSet<Order> Orders { get; set; } = new ();
	}
}