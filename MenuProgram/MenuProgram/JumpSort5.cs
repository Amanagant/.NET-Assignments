using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
   

public class JumpSort
    {
        public static int JumpSearch(int[] arr, int x)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while (arr[prev] < x)
            {
                prev++;

                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (arr[prev] == x)
                return prev;

            return -1;
        }

        public static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public static void main(string[] args)
        {
            int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };
            int elementToSearch = 20;

            Console.WriteLine("Array: ");
            PrintArray(array);

            // Jump Search
            int jumpIndex = JumpSearch(array, elementToSearch);
            if (jumpIndex != -1)
                Console.WriteLine($"Element {elementToSearch} found at index {jumpIndex} using Jump Search.");
            else
                Console.WriteLine($"Element {elementToSearch} not found using Jump Search.");

            // Linear Search
            int linearIndex = LinearSearch(array, elementToSearch);
            if (linearIndex != -1)
                Console.WriteLine($"Element {elementToSearch} found at index {linearIndex} using Linear Search.");
            else
                Console.WriteLine($"Element {elementToSearch} not found using Linear Search.");
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}

