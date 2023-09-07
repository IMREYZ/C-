using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the first integer");
                string firstInput = Console.ReadLine();

                Console.WriteLine("Please enter the second integer");
                string secondInput = Console.ReadLine();

                int firstNumber = Int32.Parse(firstInput);
                int secondNumber = Int32.Parse(secondInput);

                int result = firstNumber / secondNumber;
                Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is {result}"); 
            } 
            
            catch (FormatException error)
            {
                Console.WriteLine($"An format exception was thrown: {error.Message}");
            }

            catch (Exception error)
            {
                Console.WriteLine($"An exception was thrown: {error.Message}");
            }

        }
    }
}
