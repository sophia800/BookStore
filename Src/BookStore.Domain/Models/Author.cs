namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Author : IModel
	{
		private string _name;

		private string _biography;

		public Guid Id { get; } = Guid.NewGuid ();

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

		public Author ()
		{ }

		public Author ( string name )
		{
			if ( string.IsNullOrEmpty ( name ) )
				throw new ArgumentException ( "Name is null or empty" , nameof ( name ) );

			_name = name;
		}
	}
}