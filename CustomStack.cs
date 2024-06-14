using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;









using System;
using System.Collections.Generic;

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

        // Pushing integers onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Push(70);

        // Demonstrate LIFO behavior
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}