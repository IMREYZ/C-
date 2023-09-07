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

        static string reverseString(string str) // Вспомогательные ф-ии
        {
            char[] arrayOfChars = str.ToCharArray();
            Array.Reverse(arrayOfChars);

            return new string(arrayOfChars);
        }

        static string get16CC(int num) // Вспомогательные ф-ии
        {
            if (num == 0)
            {
                return "0";
            }

            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                [0] = "0",
                [1] = "1",
                [2] = "2",
                [3] = "3",
                [4] = "4",
                [5] = "5",
                [6] = "6",
                [7] = "7",
                [8] = "8",
                [9] = "9",
                [10] = "A",
                [11] = "B",
                [12] = "C",
                [13] = "D",
                [14] = "E",
                [15] = "F"
            };

            string result = "";

            while (num > 0)
            {
                int mod = num % 16;
                string digit = dict[mod];
                result += digit;

                num /= 16;
            }

            return reverseString(result);
        }





        static void Main(string[] args) // main
        {
            try
            {
                int numberInput = Int32.Parse(Console.ReadLine());
                string number16CC = get16CC(numberInput);
                string number16CC_Lower = getToLowerString(number16CC);

                Console.WriteLine(number16CC_Lower);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
