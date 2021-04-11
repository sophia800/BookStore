namespace BookStore.Domain.Models
{
	using System;
	using Interfaces;

	public class Reader : IModel
	{
		private string _name;

		private string _email;

		private string _city;

		private string _street;

		private string _house;

		public Guid Id { get; } = Guid.NewGuid ();

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}

		public string House
		{
			get { return _house; }
			set { _house = value; }
		}

		//FIXME: Assign all method parameters, with validations
		public Reader ( string name , string email , string city , string street , string house )
		{
			if ( string.IsNullOrEmpty ( name ) )
				throw new ArgumentException ( "Name is null or empty" , nameof ( name ) );
		}
	}
}