namespace BookStore.Persistence.Helpers.DataBaseHelpers
{
	using System.IO;

	public static class DataBaseManagerHelpers
	{
		public static void EnsureDataBaseDirectoryCreated ( string dataBasePath )
		{
			if ( !Directory.Exists ( dataBasePath ) )
				Directory.CreateDirectory ( dataBasePath );
		}
	}
}