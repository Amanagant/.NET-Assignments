using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program5
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static void main(string[] args)
        {
            int[] array = { 10, 50, 90, 40, 30, 20, 80, 70 };

            Console.WriteLine("Array before sorting:");
            PrintArray(array);

            SelectionSort(array);

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






