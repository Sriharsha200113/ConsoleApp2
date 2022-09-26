using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Input side 1 of triangle: ");
            int sidea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            int sideb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            int sidec = Convert.ToInt32(Console.ReadLine());



            if (sidea == sideb && sideb == sidec)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sidea == sideb || sidea == sidec || sideb == sidec)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }

        }

    }
}
