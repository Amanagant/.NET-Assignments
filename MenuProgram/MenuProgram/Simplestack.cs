using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SimpleStack<T>
    {
        private readonly List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack");
            }

            int lastIndex = items.Count - 1;
            T item = items[lastIndex];
            items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot peek into an empty stack");
            }

            return items[items.Count - 1];
        }
    }

    class Program3
    {
        static void main(string[] args)
        {
            SimpleStack<int> stack = new SimpleStack<int>();

            // Pushing elements onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

        // Peeking at the top element
        Console.WriteLine("Top element: " + stack.Peek());

            // Popping elements from the stack
            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Popped element: " + stack.Pop());

            // Trying to pop from an empty stack
            try
            {
                stack.Pop();
                
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


