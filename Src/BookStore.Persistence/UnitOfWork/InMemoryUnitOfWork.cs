namespace BookStore.Persistence.UnitOfWork
{
	using System;
	using System.Threading.Tasks;
	using Repositories.Interfaces;
	using Interfaces;
	using Domain.Models.Interfaces;
	using Services;
	using System.IO;
	using Repositories;

	public sealed class InMemoryUnitOfWork : IUnitOfWork
	{
		private readonly DataBaseManager _dataBaseManager;

		public InMemoryUnitOfWork ( DataBaseManager dataBaseManager )
		{
			_dataBaseManager = dataBaseManager;
		}

		public IRepository<TModel> Repository<TModel> ()
		   where TModel : IModel
		{
			_dataBaseManager.EnsureDataBaseFilesCreated ( typeof ( TModel ) );

			var tableFilePath = FormTableFilePath ( typeof ( TModel ) );

			return new InMemoryRepository<TModel> ( tableFilePath );
		}

		private string FormTableFilePath ( Type modelType )
		{
			var tableName = $"{modelType.Name}.json";

			return Path.Combine ( _dataBaseManager.DbDirectoryPath , tableName );
		}
	}
}