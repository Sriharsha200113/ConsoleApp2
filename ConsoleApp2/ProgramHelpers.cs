

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char f, s, t;
            f= Convert.ToChar(Console.ReadLine());
            s= Convert.ToChar(Console.ReadLine());
            t= Convert.ToChar(Console.ReadLine());
            Class1 Su = new Class1();
            Su.Sunny(f, s, t);



        }
    }
}