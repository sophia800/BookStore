namespace BookStore.Domain.Models.Interfaces
{
	using System;

	public interface IModel
	{
		Guid Id { set; get; }
	}
}