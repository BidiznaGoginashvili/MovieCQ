using Microsoft.EntityFrameworkCore;

namespace Movie.Infrastructure.DataBase
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OKIRIV8; Database=Movies; Trusted_Connection=True");
        }

        public DbSet<Domain.Movies.Movie> Movie { get; set; }
        public DbSet<Domain.Actors.MovieActors> MovieActors { get; set; }
        public DbSet<Domain.Directors.MovieDirector> MovieDirector { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieDetailReadModel> MovieDetailReadModel { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieDetailsActorReadModel> MovieDetailsActorReadModel { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieDetailsDirectorReadModel> MovieDetailsDirectorReadModel { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieListReadModel> MovieListReadModel { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieListActorReadModel> MovieListActorReadModel { get; set; }
        public DbSet<Domain.Movies.ReadModel.MovieListDirectorReadModel> MovieListDirectorReadModel { get; set; }

        public DbSet<Domain.Actors.Actor> Actor { get; set; }
        public DbSet<Domain.Directors.Director> Director { get; set; }
        public DbSet<Domain.Genres.Genre> Genre { get; set; }
        public DbSet<Domain.Images.Images> Image { get; set; }
    }
}
