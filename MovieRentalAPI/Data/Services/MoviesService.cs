using MovieRentalAPI.Models;
using MovieRentalAPI.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MovieRentalAPI.Data.Services
{
    public class MoviesService
    {
        public AppDBContext _context;

        public MoviesService(AppDBContext context)
        {
            _context = context;
        }

        public void AddMovie(MovieVM movie)
        {
            var _movie = new Movie()
            {
                MovieTitle = movie.MovieTitle,
                MovieDescription = movie.MovieDescription,
                Genre = movie.Genre
            };
            _context.Movies.Add(_movie);
            _context.SaveChanges();
        }


       
        public List<Movie> GetAllMovies() => _context.Movies.ToList();


        public Movie GetMoviesById(int MovieId) => _context.Movies.FirstOrDefault(m => m.Id == MovieId);



    }
}
