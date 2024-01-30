using AssignmentOnModelValidation.Models;

namespace AssignmentOnModelValidation.Repository
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        List<Movie> GetAllMovies();

        Movie GetMovieByName(string movieName);

        List<Movie> GetMoviesByActor(string actorName);
        List<Movie> GetMoviesByReleaseYear(int year);

        List<Movie> GetMoviesByDirector(string directorName);
    }
}
