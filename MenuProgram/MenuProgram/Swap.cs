using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class Swap
    
    {
        static void main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            // Swapping without using a third variable
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}

