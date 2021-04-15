namespace BookStore.Domain.Models
{
    using System;
    using Interfaces;

    public class Reader : IPerson, IModel
    {
        private string _name;

        private string _email;

        private string _city;

        private string _street;

        private string _house;

        public Guid Id { get; } = Guid.NewGuid ();

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string House
        {
            get => _house;
            set => _house = value;
        }

        public Reader ()
        { }

        public Reader ( string name , string email , string city , string street , string house )
        {
            if ( string.IsNullOrEmpty ( name ) )
                throw new ArgumentException ( "Name is null or empty" , nameof ( name ) );

            if ( string.IsNullOrEmpty ( email ) )
                throw new ArgumentException ( "Email is null or empty" , nameof ( email ) );

            if ( string.IsNullOrEmpty ( city ) )
                throw new ArgumentException ( "City is null or empty" , nameof ( city ) );

            if ( string.IsNullOrEmpty ( street ) )
                throw new ArgumentException ( "Street is null or empty" , nameof ( street ) );

            if ( string.IsNullOrEmpty ( house ) )
                throw new ArgumentException ( "House is null or empty" , nameof ( house ) );

            _name = name;
            _email = email;
            _city = city;
            _street = street;
            _house = house;
        }
    }
}