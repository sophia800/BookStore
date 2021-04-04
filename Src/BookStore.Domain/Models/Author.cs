namespace BookStore.Domain.Models
{
    public class Author
    {
        private string _name;

        private string _biography;

        public void SetName ( string name )
        {
            _name = name;
        }

        public string GetName ()
        {
            return _name;
        }

        public void SetBiography ( string biography )
        {
            _biography = biography;
        }

        public string GetBiography ()
        {
            return _biography;
        }
    }
}