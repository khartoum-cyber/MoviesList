using Microsoft.EntityFrameworkCore;
using MoviesList.Data;
using MoviesList.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoviesList.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesListContext _context;
        public MovieRepository(MoviesListContext context) => this._context = context;

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movie.ToList();
        }
        public Movie GetById(int MovieID)
        {
            return _context.Movie.Find(MovieID);
        }
        public void Insert(Movie movie)
        {
            _context.Movie.Add(movie);
        }
        public void Update(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
        }
        public void Delete(int MovieID)
        {
            Movie movie = _context.Movie.Find(MovieID);
            _context.Movie.Remove(movie);
        }
        public void Any(int MovieID)
        {
            var movie = _context.Movie.Find();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
