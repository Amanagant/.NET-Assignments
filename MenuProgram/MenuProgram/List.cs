using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{


public class SimpleStack<T>
    {
        private T[] items;
        private int top = -1;
        private const int DefaultCapacity = 10;

        public SimpleStack(int capacity = DefaultCapacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");

            items = new T[capacity];
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
                Array.Resize(ref items, items.Length * 2);

            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            T item = items[top--];
            return item;
        }

        public T Peek()
        {
            if (top == -1)
                throw new InvalidOperationException("Cannot peek into an empty stack.");

            return items[top];
        }
    }

    class Program2
    {
        static void main(string[] args)
        {
            SimpleStack<int> intStack = new SimpleStack<int>();
            SimpleStack<string> stringStack = new SimpleStack<string>();
            SimpleStack<decimal> decimalStack = new SimpleStack<decimal>();

            // Pushing 5 numbers onto the stacks
            for (int i = 1; i <= 5; i++)
            {
                intStack.Push(i * 10);
                stringStack.Push($"Item {i}");
                decimalStack.Push(i * 10.5m);
            }

            // Displaying pushed elements from each stack
            Console.WriteLine("Pushed elements from the stacks:");
            Console.WriteLine("Int Stack:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"- {intStack.Pop()}");
            }

            Console.WriteLine("String Stack:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"- {stringStack.Pop()}");
            }

            Console.WriteLine("Decimal Stack:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"- {decimalStack.Pop()}");
            }

            // Trying to pop from an empty stack
            try
            {
                intStack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

