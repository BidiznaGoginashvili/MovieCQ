using Microsoft.AspNetCore.Mvc;
using Movie.Application.Infrastructure.Queries;
using Movie.Application.Infrastructure.Commands;
using Movie.Application.Queries.MovieDetails;

namespace Movie.Controllers.Movie
{
    public class MovieController : Controller
    {
        #region Fields

        private readonly CommandExecutor _commandExecutor;
        private readonly QueryExecutor _queryExecutor;

        #endregion

        #region Ctor

        public MovieController(CommandExecutor commandExecutor, QueryExecutor queryExecutor)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
        }

        #endregion

        #region Methods

        public IActionResult MovieDetail(MovieDetailsQuery query)
        {
            var listing = _queryExecutor.Execute<MovieDetailsQuery, MovieDetailsQueryResult>(query);
            
            return View(listing.Data);
        }

        #endregion
    }
}