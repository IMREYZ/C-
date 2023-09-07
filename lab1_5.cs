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

            double perimetr = double.Parse(Console.ReadLine());
            double side = perimetr / 3;
            double square = Math.Sqrt(perimetr * (perimetr - side) * (perimetr - side) * (perimetr - side));

            Console.WriteLine("Сторона Площадь");
            Console.WriteLine($" {side:F2}   {square:F2}");
 
        }
    }
}
