using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStorage.Model
{
    internal class MovieLibrary
    {
        private Movie[] movies = new Movie[5];
        private int movieCount = 0;

        public void UploadMovie(string movieTitle)
        {
            if (movieCount < movies.Length)
            {
                movies[movieCount] = new Movie(movieTitle);
                movieCount++;
                Console.WriteLine("Movie uploaded successfully.");
            }
            else
            {
                Console.WriteLine("Storage is full. Cannot upload more movies.");
            }
        }

        public void DisplayMovies()
        {
            if (movieCount == 0)
            {
                Console.WriteLine("Storage is empty.");
            }
            else
            {
                Console.WriteLine("Movies in storage:");
                for (int i = 0; i < movieCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i].Title}");
                }
            }
        }

        public void DeleteMovie(int index)
        {
            if (index >= 0 && index < movieCount)
            {
                for (int i = index; i < movieCount - 1; i++)
                {
                    movies[i] = movies[i + 1];
                }
                movies[movieCount - 1] = null;
                movieCount--;
                Console.WriteLine("Movie deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid movie index.");
            }
        }
    }
}