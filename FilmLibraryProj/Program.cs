using MySql.Data.MySqlClient;
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
        public static void Main(string[] args)
        {
            String movieName, movieGenre, exitFlag;
            String connString = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=film";
            int movieRating = 0;
            List<Movie> movies = new List<Movie>();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            String queryString = "CREATE TABLE IF NOT EXISTS Films (FilmID int, movieName char(50), movieGenre char(50), movieRating int)";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.BeginExecuteNonQuery();

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
