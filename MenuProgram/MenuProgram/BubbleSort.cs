using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program4
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };

            Console.WriteLine("Array before sorting:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("Array after sorting:");
            PrintArray(array);
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



