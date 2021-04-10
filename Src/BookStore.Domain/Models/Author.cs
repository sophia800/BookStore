using System;

namespace BookStore.Domain.Models
{
	public class Author
	{
		private string _name;

		private string _biography;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Biography
		{
			get { return _biography; }
			set { _biography = value; }
		}

		public Author ( string name )
		{
			if ( string.IsNullOrEmpty ( name ) )
				throw new ArgumentException ( "Name is null or empty" , nameof ( name ) );

			_name = name;
		}
	}
}