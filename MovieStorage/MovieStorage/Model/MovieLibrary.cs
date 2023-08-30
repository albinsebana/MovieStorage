using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStorage.Model
{
    internal class MovieLibrary
    {
        private List<Movie> movies = new List<Movie>();

        public void UploadMovie(int movieId, string movieName, int year, string director)
        {
            movies.Add(new Movie(movieId, movieName, year, director));
            Console.WriteLine("Movie uploaded successfully.");
        }

        public void DisplayMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("Storage is empty.");
            }
            else
            {
                Console.WriteLine("Movies in storage:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i].MovieName}");
                }
            }
        }

        public void DeleteMovie(int index)
        {
            if (index >= 0 && index < movies.Count)
            {
                movies.RemoveAt(index);
                Console.WriteLine("Movie deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid movie index.");
            }
        }
    }
}
