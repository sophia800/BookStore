namespace BookStore.Domain.Models.Interfaces
{
	using System;

	public abstract class BaseModel : IModel
	{
		public Guid Id { get; set; }
	}
}