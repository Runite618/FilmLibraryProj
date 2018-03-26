using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryProj
{
    class Program
    {
        static void Main(string[] args)
        {
            String movieName, movieGenre, exitFlag;
            int movieRating = 0;
            List<Movie> movies = new List<Movie>();

            while (true)
            {
                Console.WriteLine("Please enter a movie name, genre and rating");
                Console.WriteLine("Movie name:");
                movieName = Console.ReadLine();
                Console.WriteLine("Movie genre:");
                movieGenre = Console.ReadLine();
                Console.WriteLine("Movie rating: ");
                Int32.TryParse(Console.ReadLine(), out movieRating);
                Movie movie = new Movie(movieName, movieGenre, movieRating);
                movies.Add(movie);
                Console.WriteLine("Do you wish to exit program and display list of movies? [y/n]");
                exitFlag = Console.ReadLine();
                if(exitFlag == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("List of movies:");

            foreach (Movie movie in movies) {
                Console.WriteLine(movie.getName() + ", " + movie.getGenre() + ", " + movie.getRating());
            }

            Console.ReadLine();
        }
    }
}
