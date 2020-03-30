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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Genres.MovieGenre>()
                .HasKey(bc => new { bc.MovieId, bc.GenreId });
            modelBuilder.Entity<Domain.Genres.MovieGenre>()
                .HasOne(bc => bc.Movie)
                .WithMany(b => b.MovieGenres)
                .HasForeignKey(bc => bc.MovieId);
            modelBuilder.Entity<Domain.Genres.MovieGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.MovieGenres)
                .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<Domain.Actors.MovieActor>()
                   .HasKey(bc => new { bc.MovieId, bc.ActorId });
            modelBuilder.Entity<Domain.Actors.MovieActor>()
                .HasOne(bc => bc.Movie)
                .WithMany(b => b.MovieActors)
                .HasForeignKey(bc => bc.MovieId);
            modelBuilder.Entity<Domain.Actors.MovieActor>()
                .HasOne(bc => bc.Actor)
                .WithMany(c => c.MovieActors)
                .HasForeignKey(bc => bc.ActorId);

            modelBuilder.Entity<Domain.Directors.MovieDirector>()
               .HasKey(bc => new { bc.MovieId, bc.DirectorId });
            modelBuilder.Entity<Domain.Directors.MovieDirector>()
                .HasOne(bc => bc.Movie)
                .WithMany(b => b.MovieDirectors)
                .HasForeignKey(bc => bc.MovieId);
            modelBuilder.Entity<Domain.Directors.MovieDirector>()
                .HasOne(bc => bc.Director)
                .WithMany(c => c.MovieDirectors)
                .HasForeignKey(bc => bc.DirectorId);

            modelBuilder.Entity<Domain.Movies.ReadModel.MovieDetailReadModel>()
                .HasOne(a => a.MovieDirector)
                .WithOne(b => b.MovieDetailReadModel)
                .HasForeignKey<Domain.Movies.ReadModel.MovieDetailsDirectorReadModel>(b => b.MovieDetailReadModelId);

            modelBuilder.Entity<Domain.Movies.ReadModel.MovieDetailReadModel>()
                .HasMany(c => c.MovieActor)
                .WithOne(e => e.MovieDetailReadModel);

            modelBuilder.Entity<Domain.Movies.ReadModel.MovieListReadModel>()
               .HasMany(c => c.MovieActor)
               .WithOne(e => e.MovieListReadModel);

            modelBuilder.Entity<Domain.Movies.ReadModel.MovieListReadModel>()
                .HasOne(a => a.MovieDirector)
                .WithOne(b => b.MovieListReadModel)
                .HasForeignKey<Domain.Movies.ReadModel.MovieListDirectorReadModel>(b => b.MovieListReadModelId);
        }

        public DbSet<Domain.Movies.Movie> Movie { get; set; }
        public DbSet<Domain.Genres.MovieGenre> MovieGenre { get; set; }
        public DbSet<Domain.Actors.MovieActor> MovieActor { get; set; }
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
