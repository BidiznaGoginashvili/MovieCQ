using Movie.Application.Commands.Movie;
using Movie.Application.Infrastructure.Events;

namespace Movie.Application.Events.Movie
{
    public class CreateMovieEventHandler : EventHandler<CreateMovieCommand>
    {
        public override void Handle(CreateMovieCommand command)
        {
            //Movie Aggregate Insert Logic
            //MovieDetailsReadModel Insert Logic
            //MovieListReadModel Insert Logic
            throw new System.NotImplementedException();
        }
    }
}
