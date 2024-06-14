using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  using System;
public class ArrayOperations
    {
        // Method to slice an array
        public static int[] SliceArray(int[] array, int startIndex, int endIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (startIndex < 0 || endIndex >= array.Length || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("Start or end index is out of range.");
            }

            int length = endIndex - startIndex + 1;
            int[] slicedArray = new int[length];
            Array.Copy(array, startIndex, slicedArray, 0, length);

            return slicedArray;
        }

        // Method to insert an element into an array
        public static int[] InsertElement(int[] array, int element, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            int[] newArray = new int[array.Length + 1];
            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = element;
                }
                else
                {
                    newArray[i] = array[j];
                    j++;
                }
            }

            return newArray;
        }

        // Method to update an element in an array
        public static void UpdateElement(int[] array, int index, int newValue)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            array[index] = newValue;
        }

        // Method to reverse an array
        public static void ReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            Array.Reverse(array);
        }

        // Main method to test the functionality
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Test SliceArray
            int[] slicedArray = SliceArray(array, 3, 7);
            Console.WriteLine("Sliced array: " + string.Join(", ", slicedArray));

            // Test InsertElement
            int[] arrayAfterInsert = InsertElement(array, 11, 5);
            Console.WriteLine("Array after insertion: " + string.Join(", ", arrayAfterInsert));

            // Test UpdateElement
            UpdateElement(array, 2, 20);
            Console.WriteLine("Array after update: " + string.Join(", ", array));

            // Test ReverseArray
            ReverseArray(array);
            Console.WriteLine("Reversed array: " + string.Join(", ", array));
        }
    }

