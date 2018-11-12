namespace MoviesLibrary.Models
{
    using System.Collections.Generic;

    public class Actor
    {
        public Actor()
        {
            this.Movies = new List<Movie>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Movie> Movies { get; set; } //better name 

    }
}
