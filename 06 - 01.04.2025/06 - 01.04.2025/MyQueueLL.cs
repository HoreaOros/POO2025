using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06___01._04._2025
{
    public class MyQueueLL<T> : IQueue<T>
    {
        private int _count = 0;
        public int Count => _count;

        Node front = null;
        Node back = null;

        #region Methods
        public T Dequeue()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = back.Value;
            back = back.Next;
            back.Prev = null;
            _count--; 
            return item;
        }

        public void Enqueue(T item)
        {
            Node node = new Node()
            {
                Value = item,
                Next = null,
                Prev = front
            };
            if(back == null)
            {
                back = node;
            }
            else
            {
                front.Next = node;
            }
            front = node;
            _count++;
        }
        #endregion
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node current = back;
            sb.Append("[");
            sb.Append($"Count: {Count}, ");
            while (current != null)
            {
                sb.Append(current.Value + " ");
                current = current.Next;
            }
            sb.Append("]");
            return sb.ToString();
        }
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }
        }
    }
}
