using AssignmentOnModelValidation.Models;

namespace AssignmentOnModelValidation.Repository
{
    public class MovieRespository:IMovieRepository
    {
        List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            try 
            {
                movies.Add(movie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetAllMovies()
        {
          
            try { return movies; } 
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public Movie GetMovieByName(string movieName)
        {
            try 
            {
                Movie moviesByName = new Movie();
                foreach (Movie movie in movies) 
                {
                    if(movie.MovieName==movieName)
                    {
                        moviesByName=movie;
                        break;
                    }
                }
                return moviesByName;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMoviesByActor(string actorName)
        {
            try 
            {
                List<Movie> getMoviesByActorName = new List<Movie>();
                foreach(Movie movie in movies)
                {
                    if (movie.ActorName.Equals(actorName)) 
                    {
                        getMoviesByActorName.Add(movie);
                    }
                }
                return getMoviesByActorName;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMoviesByDirector(string directorName)
        {
            try 
            {
                List<Movie> getMoviesByDirectorName = new List<Movie>();
                foreach (Movie movie in movies)
                {
                    if (movie.DirectorName.Equals(directorName))
                    {
                        getMoviesByDirectorName.Add(movie);
                    }
                }
                return getMoviesByDirectorName;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMoviesByReleaseYear(int year)
        {
            try 
            {
                List<Movie> getMoviesByRealeaseYear = new List<Movie>();
                foreach (Movie movie in movies)
                {
                    if (movie.RealeaseYear==year)
                    {
                        getMoviesByRealeaseYear.Add(movie);
                    }
                }
                return getMoviesByRealeaseYear;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
