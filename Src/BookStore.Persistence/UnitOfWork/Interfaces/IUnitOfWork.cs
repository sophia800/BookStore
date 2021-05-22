namespace BookStore.Persistence.UnitOfWork.Interfaces
{
	using Domain.Models.Interfaces;
	using Repositories.Interfaces;

	public interface IUnitOfWork
	{
		IRepository<TModel> Repository<TModel> ()
			where TModel : IModel;
	}
}