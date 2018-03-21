using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryProj
{
    public class Movie
    {
        private String name { get; set; }
        private String genre { get; set; }
        private int rating { get; set; }

        public Movie(String name, String genre, int rating)
        {
            this.name = name;
            this.genre = genre;
            this.rating = rating;
        }
    }
}
