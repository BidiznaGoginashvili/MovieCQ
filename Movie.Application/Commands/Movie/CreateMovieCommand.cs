using System;
using System.Collections.Generic;
using Movie.Application.Infrastructure;
using Movie.Application.Infrastructure.Events;
using Movie.Application.Infrastructure.Commands;

namespace Movie.Application.Commands.Movie
{
    public class CreateMovieCommand : Command
    {
        protected readonly EventNotifier _notifier = new EventNotifier();

        public string Title { get; set; }

        public decimal Budget { get; set; }

        public decimal Salary { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int DirectorId { get; set; }

        public IList<int> Genres { get; set; }

        public IList<int> ActorIds { get; set; }

        public override CommandExecutionResult Execute()
        {
            try
            {
                var result = new CommandExecutionResult();

                _notifier.Notify(new CreateMovieCommand()
                {
                    Title = Title,
                    Budget = Budget,
                    Salary = Salary,
                    ImagePath = ImagePath,
                    Description = Description,
                    ReleaseDate = ReleaseDate,
                    DirectorId = DirectorId,
                    Genres = Genres,
                    ActorIds = ActorIds
                });

                return Ok();
            }
            catch (Exception exception)
            {
                return Fail(exception);
            }
        }
    }
}
