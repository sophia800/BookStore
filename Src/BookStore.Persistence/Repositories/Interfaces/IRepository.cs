namespace BookStore.Persistence.Repositories.Interfaces
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using Domain.Models.Interfaces;

	public interface IRepository<TModel>
		where TModel : IModel
	{
		List<TModel> GetAll ();

		void Commit ( TModel model );

		void Commit ( params TModel[] models );

		void Commit ( IEnumerable<TModel> models );
	}
}