using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Domain.Actors
{
    public class MovieActor
    {
        public int MovieId { get; private set; }

        public Movies.Movie Movie { get; private set; }

        public int ActorId { get; private set; }

        public Actor Actor { get; private set; }
    }
}
