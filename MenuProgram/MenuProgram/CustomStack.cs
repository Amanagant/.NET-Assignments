using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class CustomStack<T>
    {
        private List<T> _elements = new List<T>();

        public void Push(T item)
        {
            _elements.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T item = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return _elements[_elements.Count - 1];
        }

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

            // Pushing integers onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Demonstrate LIFO behavior
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }


