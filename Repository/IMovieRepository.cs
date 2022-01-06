using MoviesList.Models;
using System.Collections.Generic;

namespace MoviesList.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int MovieID);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Delete(int MovieID);
        void Any(int MovieID);
        void Save();
    }
}
