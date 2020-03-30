using System.Collections.Generic;

namespace Movie.Domain.Actors
{
    public class Actor
    {
        public Actor(int id, string lastName, string firstName)
        {
            Id = Id;
            LastName = lastName;
            FirstName = firstName;
        }

        public int Id { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
