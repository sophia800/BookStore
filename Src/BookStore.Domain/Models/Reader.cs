namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Reader : IPerson, IModel
	{
		public Guid Id { set; get; } = Guid.NewGuid ();

		public string Name { get; set; }

		public string Email { get; set; }

		public string City { get; set; }

		public string Street { get; set; }

		public string House { get; set; }
	}
}