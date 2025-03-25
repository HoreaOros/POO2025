using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___25._03
{
    public class LinkedStack<T> : IStack<T>
    {
        private Node top = null;
        private int _count = 0;
        private class Node
        {
            public T? Value { get; set; }
            public Node? Next { get; set; }
        }
        public int Capacity => _count;

        public int Count => _count;

        public T Peek()
        {
            if(top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.Value;
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = top.Value;
            top = top.Next;
            _count--;
            return value;
        }

        public void Push(T value)
        {
            Node newNode = new Node
            {
                Value = value,
                Next = top
            };
            top = newNode;
            _count++;
        }
    }
}
