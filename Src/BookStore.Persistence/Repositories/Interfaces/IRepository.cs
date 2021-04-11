namespace BookStore.Persistence.Repositories.Interfaces
{
	using System.Collections.Generic;
	using Domain.Models.Interfaces;

	public interface IRepository<TModel>
		where TModel : IModel
	{
		HashSet<TModel> GetAll ();
	}
}