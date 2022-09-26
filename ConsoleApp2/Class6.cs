using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height(in cms) : ");
            int height = int.Parse(Console.ReadLine());
            if (height < 135)
            {
                Console.WriteLine("Height is Short");
            }
            else if (height >= 135 && height <= 180)
            {
                Console.WriteLine("Height is Average");
            }
            else
            {
                Console.WriteLine("Height is Tall");
            }
        }

    }
}
