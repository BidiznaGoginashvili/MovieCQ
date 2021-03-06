﻿using System.Collections.Generic;

namespace Movie.Domain.Directors
{
    public class Director
    {
        public Director(int id, string lastName, string firstName)
        {
            Id = Id;
            LastName = lastName;
            FirstName = firstName;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public ICollection<MovieDirector> MovieDirectors { get; set; }
    }
}
