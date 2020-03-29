using System.Collections.Generic;

namespace Movie.Domain.Actors
{
    public class Actor
    {
        public Actor(int id, string lastName, string firstName, IList<MovieActors> movieActors)
        {
            Id = Id;
            LastName = lastName;
            FirstName = firstName;
            MovieActor = movieActors;
        }

        public int Id { get; private set; }

        public string LastName { get; set; }
        
        public string FirstName { get; set; }
        
        public IList<MovieActors> MovieActor { get; set; }
    }
}
