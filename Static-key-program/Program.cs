using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication3
{
    public class Program
    {
        static class Damo
        {
             public static int Add(int a, int b)
            {
                Console.WriteLine("Adding two numbers");
                return a + b;
            }

            public static void Padd(int a, int b)
            {
                Console.WriteLine("Subtracting two numbers");
                Console.WriteLine(a- b);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("enter 1st value");
             int x=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
             int y=int.Parse(Console.ReadLine());
             int result = Damo.Add(x, y);
            Console.WriteLine(result);
          
            Damo.Padd(54, 88);
        }
    }
}
