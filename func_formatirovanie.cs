using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Program
    {
        static string getToLowerString(string str) // Вспомогательные ф-ии
        {
            return str.ToLower();
        }

        static string get16CC(int num) // Вспомогательные ф-ии
        {
            return $"{num:X}";
        }



        static void Main(string[] args) // main
        {
 
            int numberInput = Int32.Parse(Console.ReadLine());
            string number16CC = get16CC(numberInput);
            string number16CC_Lower = getToLowerString(number16CC);

            Console.WriteLine($"{numberInput} {number16CC} {number16CC_Lower}");

        }
    }
}
