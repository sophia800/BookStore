namespace BookStore.Persistence.Repositories
{
	using System;
	using Interfaces;
	using Domain.Models.Interfaces;
	using System.IO;
	using Newtonsoft.Json;
	using System.Collections.ObjectModel;
	using System.Collections.Generic;
	using BookStore.Persistence.Helpers;
	using System.Linq;

	public sealed class InMemoryRepository<TModel> : IRepository<TModel>
		where TModel : IModel
	{
		public string TableFilePath { get; }

		public InMemoryRepository ( string tableFilePath )
		{
			if ( string.IsNullOrEmpty ( tableFilePath ) )
				throw new ArgumentNullException ( nameof ( tableFilePath ) , "Table file path is null" );

			TableFilePath = tableFilePath;
		}

		public List<TModel> GetAll ()
		{
			var modelsTextContent = File.ReadAllText ( TableFilePath );

			return JsonConvert.DeserializeObject<List<TModel>> ( modelsTextContent ) ??
				SeedData ();
		}

		private List<TModel> SeedData ()
		{
			var result =
			   Seeder.SeededDataBase
				   .OfType<TModel> ()
				   .ToList ();

			Commit ( result );

			return result;
		}

		public void Commit ( TModel model )
		{
			var serializableModel = JsonConvert.SerializeObject (
				new[]
				{
					model
				} );

			File.WriteAllText ( TableFilePath , serializableModel );
		}

		public void Commit ( params TModel[] models )
		{
			Commit ( models );
		}

		public void Commit ( IEnumerable<TModel> models )
		{
			var serializableModels = JsonConvert.SerializeObject ( models );

			File.WriteAllText ( TableFilePath , serializableModels );
		}
	}
}