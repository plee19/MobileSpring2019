using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDB movieDB = new MovieDB();
            ConsoleUI con = ConsoleUI.GetUI();
            bool moreTasks = true;
            do
            {
                Choices? choice = con.GetChoice();
                switch (choice)
                {
                    case Choices.LIST: con.OutputMovies(movieDB.GetAllMovies()); break;
                    case Choices.BYRATING: con.OutputMovies(movieDB.GetAllMoviesByRating(con.GetRating())); break;
                    case Choices.BYGENRE: con.OutputMovies(movieDB.GetAllMoviesByGenre(con.GetGenre())); break;
                    case Choices.DELETE:
                        Console.WriteLine(movieDB.DeleteMovieByIndex(con.GetMovieToDelete(movieDB.GetAllMovies()))); break;
                    case Choices.EXIT: moreTasks = false; break;
                }
            } while (moreTasks);
        }
    }
}
