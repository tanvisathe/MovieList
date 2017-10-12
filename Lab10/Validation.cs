using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validation
    {
        public static bool UserInputValidation(string _choice)
        {
            int value;
            try
            {
                //int number = Convert.ToInt32(_choice);

                if (string.IsNullOrWhiteSpace(_choice) || string.IsNullOrWhiteSpace(_choice))
                {
                    Console.WriteLine("Please enter valid numbers.");
                    return false;
                }
                else if (!Int32.TryParse(_choice, out value))
                {
                    Console.WriteLine("Please enter Non-Zero and Positive numbers as input and try again.");
                    return false;
                }
                else if (value < 1 || value >= 5)
                {
                    Console.WriteLine("That movie does not exist. Please enter a number between 1 - 5.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;

            }

        }

    }
}
