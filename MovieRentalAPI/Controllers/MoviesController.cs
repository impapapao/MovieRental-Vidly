using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalAPI.Data.Services;
using MovieRentalAPI.Models.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace MovieRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("get-all-movies")]
        public IActionResult GetAllMovies()
        {
            var allMovie = _moviesService.GetAllMovies();
            return Ok(allMovie);
        }

        [HttpGet("get-movie-by-id/{id}")]
        public IActionResult GetMovieById(int id)
        {
            var Movie = _moviesService.GetMoviesById(id);
            return Ok(Movie);
        }

        [HttpPost("add-movie")]
        public IActionResult AddMovie([FromBody]MovieVM movie)
        {
            _moviesService.AddMovie(movie);
            return Ok();
        }
    }
}
