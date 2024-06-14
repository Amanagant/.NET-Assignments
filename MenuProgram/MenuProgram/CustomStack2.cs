using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class CustomStack1
    { 
    

public class CustomStack<T>
    {
        private List<T> _elements = new List<T>();

        // Adds an item to the stack
        public void Push(T item)
        {
            _elements.Add(item);
        }

        // Removes and returns the last item added to the stack
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T item = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);
            return item;
        }

        // Returns the last item added to the stack without removing it
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return _elements[_elements.Count - 1];
        }

        // Checks if the stack is empty
        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }
    }

    class Program
    {
        static void main()
        {
            CustomStack<int> stack = new CustomStack<int>();

            // Pushing 5 integers onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("After pushing 5 elements onto the stack:");
            PrintStack(stack);

            // Pushing 7 more integers onto the stack
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);

            Console.WriteLine("After pushing 7 more elements onto the stack:");
            PrintStack(stack);

            // Pop and display elements until the stack is empty
            Console.WriteLine("Popping all elements from the stack:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }

        static void PrintStack(CustomStack<int> stack)
        {
            List<int> elements = new List<int>();
            while (!stack.IsEmpty())
            {
                elements.Add(stack.Pop());
            }

            elements.Reverse();
            foreach (var element in elements)
            {
                Console.Write(element + " ");
                stack.Push(element); // push them back to the stack to keep it intact
            }
            Console.WriteLine();
        }
    }
}
}
