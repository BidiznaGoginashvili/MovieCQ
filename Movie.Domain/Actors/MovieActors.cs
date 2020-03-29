﻿namespace Movie.Domain.Actors
{
    public class MovieActors
    {
        public int MovieId { get; private set; }
        
        public Movies.Movie Movie { get; private set; }
        
        public int ActorId { get; private set; }

        public Actor Actor{ get; private set; }
    }
}
