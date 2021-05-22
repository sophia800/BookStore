namespace BookStore.Domain.Models
{
	using System.Collections.Generic;
	using Interfaces;

	public sealed class Reader : BaseModel, IPerson
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string City { get; set; }

		public string Street { get; set; }

		public string House { get; set; }

		public HashSet<Order> Orders { get; set; } = new ();
	}
}