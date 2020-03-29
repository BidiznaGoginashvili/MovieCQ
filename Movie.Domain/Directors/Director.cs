using System.Collections.Generic;

namespace Movie.Domain.Directors
{
    public class Director
    {
        public Director(int id, string lastName, string firstName, IList<MovieDirector> movieDirector)
        {
            Id = Id;
            LastName = lastName;
            FirstName = firstName;
            MovieDirector = movieDirector;
        }

        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public IList<MovieDirector> MovieDirector { get; private set; }
    }
}
