using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;


            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
        }

    }
}
