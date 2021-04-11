namespace BookStore.Persistence.Services
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Reflection;

	public sealed class DataBaseManager
	{
		public string DbDirectoryPath { get; }

		public DataBaseManager ( IEnumerable<Type> modelsType = default , string dbDirectoryPath = "DataBase" )
		{
			DbDirectoryPath = FormFullPathToDirectory ( dbDirectoryPath );

			EnsureDataBaseDirectoryCreated ();

			if ( modelsType != null )
				EnsureDataBaseFilesCreated ( modelsType );
		}

		public static string FormFullPathToDirectory ( string dbDirectoryPath ) =>
			Path.Combine (
				path1: Directory.GetCurrentDirectory () ,
				path2: dbDirectoryPath );

		public void EnsureDataBaseFilesCreated ( IEnumerable<Type> modelsType )
		{
			foreach ( var modelType in modelsType )
			{
				var tableName = $"{modelType.Name}.json";

				var fullPathToTableFile = Path.Combine ( DbDirectoryPath , tableName );

				if ( !File.Exists ( fullPathToTableFile ) )
					File.Create ( fullPathToTableFile );
			}
		}

		public void EnsureDataBaseFilesCreated ( params Type[] modelsType )
		{
			foreach ( var modelType in modelsType )
			{
				var tableName = $"{modelType.Name}.json";

				var fullPathToTableFile = Path.Combine ( DbDirectoryPath , tableName );

				if ( !File.Exists ( fullPathToTableFile ) )
					File.Create ( fullPathToTableFile );
			}
		}

		private void EnsureDataBaseDirectoryCreated ()
		{
			if ( !Directory.Exists ( DbDirectoryPath ) )
				Directory.CreateDirectory ( DbDirectoryPath );
		}
	}
}