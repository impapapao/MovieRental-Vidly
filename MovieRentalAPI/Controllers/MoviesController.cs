using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalAPI.Data.Services;
using MovieRentalAPI.Models.ViewModels;

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

        [HttpPost("add-movie")]
        public IActionResult AddMovie([FromBody]MovieVM movie)
        {
            _moviesService.AddMovie(movie);
            return Ok();
        }
    }
}
