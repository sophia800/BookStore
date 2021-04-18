namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Book : IModel
	{
		public Guid Id { get; } = Guid.NewGuid ();

		public Author Author { get; set; }

		public string Title { get; set; }
	}
}