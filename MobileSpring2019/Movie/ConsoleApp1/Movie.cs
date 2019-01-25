using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Movie
    {
        public String Name { get; set; }
        public Rating Rating { get; set; }
        public Genre Genre { get; set; }

        public Movie(String name, Rating rating, Genre genre)
        {
            this.Name = name;
            this.Rating = rating;
            this.Genre = genre;
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (!(o.GetType() == typeof(Movie))) return false;
            Movie movie = (Movie)o;
            return Equals(this.Name, movie.Name) &&
                    this.Rating == movie.Rating &&
                    this.Genre == movie.Genre;
        }

    public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    public override String ToString()
        {
            return "Movie{" +
                    "name='" + Name + '\'' +
                    ", rating=" + Rating +
                    ", genre=" + Genre +
                    '}';
        }
    }
}
