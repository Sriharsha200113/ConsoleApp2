using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Input First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 2 != 0 && num2 % 2 != 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }
}
