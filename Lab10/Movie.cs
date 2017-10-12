using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string Title;
        private string Category;

        public Movie(string _title,string _category)
        {
            Category = _category;
            Title = _title;
           
        }
        public static List<Movie> InitializeMovieList()
        {
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Star Wars", "Scifi"));
            MovieList.Add(new Movie("Intersteller", "Scifi"));
            MovieList.Add(new Movie("The Matrix", "Scifi"));
            MovieList.Add(new Movie("2001: A Space Odyssey", "Scifi"));
            MovieList.Add(new Movie("E.T. The Extra Terrestrial", "Scifi"));
            MovieList.Add(new Movie("Frozen", "Animated"));
            MovieList.Add(new Movie("The Lion King", "Animated"));
            MovieList.Add(new Movie("Toy Story", "Animated"));
            MovieList.Add(new Movie("Zootopia", "Animated"));
            MovieList.Add(new Movie("Finding Nemo", "Animated"));
            MovieList.Add(new Movie("GodFather", "Drama"));
            MovieList.Add(new Movie("Catch me if you can", "Drama"));
            MovieList.Add(new Movie("Titanic", "Drama"));
            MovieList.Add(new Movie("Forrest Gump", "Drama"));
            MovieList.Add(new Movie("No Country for Old Men", "Drama"));
            MovieList.Add(new Movie("Scary Movie", "Horror"));
            MovieList.Add(new Movie("Exorcist", "Horror"));
            MovieList.Add(new Movie("It", "Horror"));
            MovieList.Add(new Movie("The Shining", "Horror"));
            MovieList.Add(new Movie("The Blair Witch Project", "Horror"));


            return MovieList;
        }

        public void GetScifiMovies(List<Movie> MovieList)
        {
            List<string> scifiMovies = new List<string>();
            foreach (var movie in MovieList)
            {
                if(movie.Category == "Scifi")
                {
                    scifiMovies.Add(movie.Title);
                }
                scifiMovies.Sort();
            }

            foreach (var movie in scifiMovies)
            {
                Console.WriteLine(movie);
            }
        }


        public void GetAnimatedMovies(List<Movie> MovieList)
        {
            List<string> animatedMovies = new List<string>();
            foreach (var movie in MovieList)
            {
                if (movie.Category == "Animated")
                {
                    animatedMovies.Add(movie.Title);
                }
                animatedMovies.Sort();
            }

            foreach (var movie in animatedMovies)
            {
                Console.WriteLine(movie);
            }
        }

        public void GetDramaMovies(List<Movie> MovieList)
        {
            List<string> dramaMovies = new List<string>();
            foreach (var movie in MovieList)
            {
                if (movie.Category == "Drama")
                {
                    dramaMovies.Add(movie.Title);
                }
                dramaMovies.Sort();
            }

            foreach (var movie in dramaMovies)
            {
                Console.WriteLine(movie);
            }
        }

        public void GetHorrorMovies(List<Movie> MovieList)
        {
            List<string> horrorMovies = new List<string>();
            foreach (var movie in MovieList)
            {
                if (movie.Category == "Horror")
                {
                    horrorMovies.Add(movie.Title);
                }
                horrorMovies.Sort();
            }

            foreach (var movie in horrorMovies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
