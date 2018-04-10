using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryProj
{
    public class Program
    {
        private String movieName, movieGenre, exitFlag;
        private String connString = "server = localhost; user id = root; persistsecurityinfo = True; database = film";
        private SqlConnection connection;
        private int movieRating = 0;
        private List<Movie> movies = new List<Movie>();

        public static void Main(string[] args)
        {
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Please enter a movie name, genre and rating");
                Console.WriteLine("Movie name:");
                program.movieName = Console.ReadLine();
                Console.WriteLine("Movie genre:");
                program.movieGenre = Console.ReadLine();
                Console.WriteLine("Movie rating: ");
                Int32.TryParse(Console.ReadLine(), out program.movieRating);
                Movie movie = new Movie(program.movieName, program.movieGenre, program.movieRating);
                program.movies.Add(movie);
                Console.WriteLine("Do you wish to exit program and display list of movies? [y/n]");
                program.exitFlag = Console.ReadLine();
                if(program.exitFlag == "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("List of movies:");

            foreach (Movie movie in program.movies) {
                Console.WriteLine(movie.getName() + ", " + movie.getGenre() + ", " + movie.getRating());

            }

            Console.ReadLine();
        }
    }
}
