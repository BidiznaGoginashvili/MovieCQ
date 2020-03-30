using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Movie.Application.Commands.Movie;
using Movie.Application.Queries.MovieDetails;
using Movie.Application.Queries.MovieListing;
using Movie.Application.Infrastructure.Queries;
using Movie.Application.Infrastructure.Commands;

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

        public IActionResult Create()
        {
            var command = new CreateMovieCommand();
            command.Title = "Title";
            command.Budget = 2154594;
            command.Salary = 4525487;
            command.ImagePath = "ImagePath";
            command.Description = "Description";
            command.ReleaseDate = DateTime.Now;
            command.DirectorId = 1;
            command.Genres = new List<int> { 1, 2 };
            command.ActorIds = new List<int> { 1, 2 };

            _commandExecutor.Execute(command);
            return View(command);
        }

        public IActionResult List(MovieListQuery query)
        {
            var listing = _queryExecutor.Execute<MovieListQuery, MovieListQueryResult>(query);

            return View(listing.Data);
        }

        public IActionResult Details(MovieDetailsQuery query)
        {
            var details = _queryExecutor.Execute<MovieDetailsQuery, MovieDetailsQueryResult>(query);
            
            return View(details.Data);
        }

        #endregion
    }
}