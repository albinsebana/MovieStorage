using MovieStorage.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieStorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieLibrary storage = new MovieLibrary();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Upload Movie");
                Console.WriteLine("2. Display Movies");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the movie title: ");
                        string movieName = Console.ReadLine();
                        Console.Write("Enter the movie ID: ");
                        int movieId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the movie year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the movie director: ");
                        string director = Console.ReadLine();
                        storage.UploadMovie(movieId, movieName, year, director);
                        break;
                    case 2:
                        storage.DisplayMovies();
                        break;
                    case 3:
                        storage.DisplayMovies();
                        Console.Write("Enter the index of the movie to delete: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        storage.DeleteMovie(index);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}