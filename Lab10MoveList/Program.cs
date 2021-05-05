using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10_Movie_List_1._1
{
    public class Movie
    {
        private string _movieTitle;
        private string _movieCategory;

        public string Movetitle
        {
            get
            {
                return _movieTitle;
            }
            set
            {
                _movieTitle = value;
            }
        }

        public string Moviecategory
        {
            get
            {
                return _movieCategory;
            }
            set
            {
                _movieCategory = value;
            }
        }

        public Movie(string title, string category)
        {
            _movieTitle = title;
            _movieCategory = category;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {



            List<Movie> movies = new List<Movie>
            {
            new Movie("Steel Magnolias",  "Drama" ),
            new Movie("American Beauty", "Drama"),
            new Movie("The Help", "Drama"),
            new Movie("Hidden Figures", "Drama"),
            new Movie("Parasite","Drama"),
            new Movie("Serenity", "Scifi"),
            new Movie("The Matrix","Scifi"),
            new Movie("The Hunger Games","Scifi"),
            new Movie("Alien","Scifi"),
            new Movie("The Terminator","Scifi"),
            new Movie("The Incredibles","Animated"),
            new Movie("Ghost In The Shell","Animated"),
            new Movie("How To Train Your Dragon","Animated"),
            new Movie("Howels Moving Castle","Animated"),
            new Movie("Lilo and Stitch","Animated"),
            new Movie("The Conjuring","Horror"),
            new Movie("Nightmare On Elm Street","Horror"),
            new Movie("Day Of The Dead","Horror"),
            new Movie("Slither","Horror"),
            new Movie("The Ring","Horror"),
            };

            while (true)
            {



                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 20 movies in this list");
                Console.WriteLine("What category are you interested in?");
                string cat_choice = Console.ReadLine();

                var results = movies.Where(x => x.Moviecategory == cat_choice);
                foreach (Movie category in results)
                {
                    Console.WriteLine(category.Movetitle);
                    //This is where we will print the list based on category
                }

                Console.WriteLine("Would you like to choose anothe category Y/N");
                string user_ch = Console.ReadLine();

                if (user_ch == "n")
                {
                    Console.WriteLine("Thank you! Goodbye!");
                    break;
                }

            }










        }
    }
}


