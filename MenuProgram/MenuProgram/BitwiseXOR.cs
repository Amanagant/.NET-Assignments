using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class BitwiseXOR
   
    {
        static void FindNonRepeating(int[] arr)
        {
            // Find XOR of all elements
            int xor = 0;
            foreach (int num in arr)
            {
                xor ^= num;
            }

            // Find the rightmost set bit
            int rightmostSetBit = xor & -xor;

            // Initialize two XOR variables for the two non-repeating elements
            int x = 0;
            int y = 0;

            // Divide the array into two groups based on rightmost set bit
            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                {
                    // XOR of group 1
                    x ^= num;
                }
                else
                {
                    // XOR of group 2
                    y ^= num;
                }
            }

            Console.WriteLine($"Two non-repeating elements are: {x} and {y}");
        }

        static void main(string[] args)
        {
            int[] arr = { 1, 2, 4, 3, 3, 2, 5, 1 };
            FindNonRepeating(arr);
        }
    }
}

