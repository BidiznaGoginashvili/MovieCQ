using System;
using System.Linq;
using System.Collections.Generic;
using Movie.Infrastructure.Repository;
using Movie.Application.Infrastructure;
using Movie.Application.Infrastructure.Queries;

namespace Movie.Application.Queries.MovieListing
{
    public class MovieListQuery : Query<MovieListQueryResult>
    {
        protected IRepository<Domain.Movies.ReadModel.MovieListReadModel> _repository = new Repository<Domain.Movies.ReadModel.MovieListReadModel>();

        public override QueryExecutionResult<MovieListQueryResult> Execute()
        {
            try
            {
                var result = new MovieListQueryResult();
                var listings = _repository.GetAll().ToList();

                result.Listing = listings.Select(movie => new MovieListQueryResult
                {
                    Id = movie.Id,
                    Genres = movie.Genres,
                    Title = movie.ImagePath,
                    ImagePath = movie.ImagePath,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                    MovieDirector = new MovieListDirectorResult()
                    {
                        FullName = movie.MovieDirector.FullName,
                        ImagePath = movie.MovieDirector.ImagePath
                    },
                    MovieActor = movie.MovieActor.Select(mact => new MovieListActorResult
                    {
                        FullName = mact.FullName,
                        ImagePath = mact.ImagePath
                    }).ToList()
                }).ToList();

                return Ok(result);
            }
            catch (Exception exception)
            {
                return Fail(exception);
            }
        }
    }

    public class MovieListQueryResult 
    {
        public List<MovieListQueryResult> Listing = new List<MovieListQueryResult>();
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genres { get; set; }

        public IList<MovieListActorResult> MovieActor { get; set; }

        public MovieListDirectorResult MovieDirector { get; set; }
    }

    public class MovieListActorResult
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }

    public class MovieListDirectorResult
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }
}
