namespace BookStore.Persistence.Services
{
	using System;
	using System.Collections.Generic;
	using System.IO;

	public sealed class DataBaseManager
	{
		private const string DbDirectory = "DataBase";

		public string DbDirectoryPath { get; }

		public DataBaseManager ( string dbDirectoryPath )
		{
			DbDirectoryPath = FormFullPathToDirectory ( dbDirectoryPath );

			EnsureDataBaseDirectoryCreated ();
		}

		public static string FormFullPathToDirectory ( string dbDirectoryPath ) =>
			Path.Combine (
				dbDirectoryPath ,
				DbDirectory );

		public void EnsureDataBaseFilesCreated ( params Type[] modelsType )
		{
			foreach ( var modelType in modelsType )
			{
				var tableName = $"{modelType.Name}.json";

				var fullPathToTableFile = Path.Combine ( DbDirectoryPath , tableName );

				if ( !File.Exists ( fullPathToTableFile ) )
				{
					using var _ =
						new FileStream ( fullPathToTableFile , FileMode.Create , FileAccess.ReadWrite );
				}
			}
		}

		private void EnsureDataBaseDirectoryCreated ()
		{
			if ( !Directory.Exists ( DbDirectoryPath ) )
				Directory.CreateDirectory ( DbDirectoryPath );
		}
	}
}