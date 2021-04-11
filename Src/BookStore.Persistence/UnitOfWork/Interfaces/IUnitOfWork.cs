namespace BookStore.Persistence.UnitOfWork.Interfaces
{
	using System.Threading.Tasks;
	using Domain.Models.Interfaces;
	using Repositories.Interfaces;

	public interface IUnitOfWork
	{
		IRepository<TModel> Repository<TModel> ()
			where TModel : IModel;

		Task CommitAsync ();
	}
}