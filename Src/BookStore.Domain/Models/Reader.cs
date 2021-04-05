namespace BookStore.Domain.Models
{
    public class Reader
    {
        private string _name;
        private string _email;
        private string _city;
        private string _street;
        private string _house;
        public void SetName ( string name )
        {
            _name = name;
        }

        public string GetName ()
        {
            return _name;
        }
        public void SetEmail ( string email )
        {
            _email = email;
        }

        public string GetEmail ()
        {
            return _email;
        }
        public void SetCity ( string city )
        {
            _city = city;
        }

        public string GetCity ()
        {
            return _city;
        }
        public void SetStreet ( string street )
        {
            _street = street;
        }

        public string GetStreet ()
        {
            return _street;
        }
        public void SetHouse ( string house )
        {
            _house = house;
        }

        public string GetHouse ()
        {
            return _house;
        }
    }
}