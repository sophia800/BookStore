namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Author : IModel, IPerson
	{
		public Guid Id { set; get; } = Guid.NewGuid ();

		public string Name { get; set; }

		public string Biography { get; set; }
	}
}