using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class generic
    
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void main(string[] args)
        {
            // Test with integers
            int x = 5;
            int y = 10;
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");

            // Test with strings
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine($"Before swap: str1 = {str1}, str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"After swap: str1 = {str1}, str2 = {str2}");

            // Test with doubles
            double d1 = 3.14;
            double d2 = 6.28;
            Console.WriteLine($"Before swap: d1 = {d1}, d2 = {d2}");
            Swap(ref d1, ref d2);
            Console.WriteLine($"After swap: d1 = {d1}, d2 = {d2}");
        }
    }
}

