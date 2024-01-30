using AssignmentOnModelValidation.Models;
using AssignmentOnModelValidation.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace AssignmentOnModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieRepository movieRepository;
        public MovieController(IMovieRepository movieRepository) 
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet,Route("GetAllMovies")]
        public IActionResult GetAllMovies() 
        {
            try 
            {
                var movies = movieRepository.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost,Route("AddMovie")]
        public IActionResult AddMovie(Movie movie) 
        {
            try 
            {
                movieRepository.AddMovie(movie);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet,Route("GetMoviesByActor/${name}")]
        public IActionResult GetMoviesByActor(string name) 
        {
            try 
            {
                var movies = movieRepository.GetMoviesByActor(name);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet, Route("GetMoviesByDirector/${name}")]
        public IActionResult GetMoviesByDirector(string name)
        {
            try 
            {
                var movies = movieRepository.GetMoviesByDirector(name);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet, Route("GetMoviesByYear/${year}")]
        public IActionResult GetMovieByYear(int year)
        {
            try 
            {
                var movies = movieRepository.GetMoviesByReleaseYear(year);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet, Route("GetMoviesByMovieName/${name}")]
        public IActionResult GetMovieByMovieName(string name)
        {
            try 
            {
                var movie = movieRepository.GetMovieByName(name);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

    }
}
