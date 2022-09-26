using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            double radius, perimeter;
            double PI = 3.14;
            Console.Write("Enter the radius: ");
            radius = double.Parse(Console.ReadLine());

            perimeter = (double)(2 * Math.PI * radius);
            Console.WriteLine("Perimeter of Circle: " + perimeter);

        }

    }
}
