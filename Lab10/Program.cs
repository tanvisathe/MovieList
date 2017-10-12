using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run == true)
            {
                
                List<Movie> MovieList = Movie.InitializeMovieList();
                Movie m = new Movie("title", "category");
                Console.WriteLine("Welcome to Movie List Application!");               
                Console.WriteLine("There are 20 movies in this list");
                Console.WriteLine("What category you are interested in?");
                Console.WriteLine("1) SciFi\n2) Animated\n3) Drama\n4) Horror\n5) Quit\n");
                var choice = Console.ReadLine();

                bool valStatus = Validation.UserInputValidation(choice);
                if(valStatus == true)
                {
                    switch (choice)
                    {
                        case "1":
                            m.GetScifiMovies(MovieList);
                            break;
                        case "2":
                            m.GetAnimatedMovies(MovieList);
                            break;
                        case "3":
                            m.GetDramaMovies(MovieList);
                            break;
                        case "4":
                            m.GetHorrorMovies(MovieList);
                            break;
                        case "5":
                            break;
                    }
                }


                run = Continue();

            }
        }

        public static bool Continue()
        {
            System.Console.WriteLine("Continue?(y/n)");
            string input = System.Console.ReadLine();
            input = input.ToLower();
            bool goAhead;
            if (input == "y")
            {
                goAhead = true;

            }
            else if (input == "n")
            {
                System.Console.WriteLine("Bye Bye!");
                goAhead = false;
            }
            else
            {
                System.Console.WriteLine("I don't understand that, please try again");
                goAhead = Continue();
            }
            return goAhead;
        }
    }
}
