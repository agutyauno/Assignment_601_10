using Assignment_601_10.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Managers
{
    internal class MovieManager
    {
        private static MovieManager _instance;
        private static readonly object _lock = new object();
        private List<Movie> movies;

        // Private constructor for Singleton
        private MovieManager()
        {
            movies = new List<Movie>();
        }

        // Singleton instance accessor
        public static MovieManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MovieManager();
                    }
                    return _instance;
                }
            }
        }

        public void Add(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie), "Movie cannot be null");
            }
            movies.Add(movie);
            Console.WriteLine($"Movie {movie.Name} added successfully.");
        }

        public void Update(string movieId, string name, string genre, int duration)
        {
            Movie? movie = movies.Find(m => m.MovieId == movieId);
            if (movie == null)
            {
                Console.WriteLine($"Movie with ID {movieId} not found.");
                return;
            }
            Console.WriteLine($"Movie {movie.Name} would be updated with new details.");
        }

        public void Remove(string movieId)
        {
            Movie? movie = movies.Find(m => m.MovieId == movieId);
            if (movie == null)
            {
                Console.WriteLine($"Movie with ID {movieId} not found.");
                return;
            }
            movies.Remove(movie);
            Console.WriteLine($"Movie {movie.Name} removed successfully.");
        }

        public void Print()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }
            Console.WriteLine("List of Movies:");
            foreach (var movie in movies)
            {
                movie.Print();
            }
        }

        public Movie? Get(string movieId)
        {
            Movie? movie = movies.Find(m => m.MovieId == movieId);
            if (movie == null)
            {
                Console.WriteLine($"Movie with ID {movieId} not found.");
            }
            return movie;
        }
    }
}
