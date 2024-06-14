using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class Bitwise
    
    {
        // Helper function to count set bits in a single integer
        static int CountBits(int x)
        {
            int count = 0;
            while (x > 0)
            {
                x &= (x - 1);  // This operation reduces the number of set bits by one
                count++;
            }
            return count;
        }

        // Main function to count set bits for all integers from 1 to n
        static void CountSetBits(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int setBitCount = CountBits(i);
                Console.WriteLine($"{i}: Number of set bit count: {setBitCount}");
            }
        }

        static void main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            CountSetBits(n);
        }
    }
}

