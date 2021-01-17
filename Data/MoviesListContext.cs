using Microsoft.EntityFrameworkCore;
using MoviesList.Models;

namespace MoviesList.Data
{
    public class MoviesListContext : DbContext
    {
        public MoviesListContext(DbContextOptions<MoviesListContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
