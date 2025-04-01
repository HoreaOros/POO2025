using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___01._04._2025
{
    public class MyQueue<T>: IQueue<T>
    {
        #region Fields
        private T[] _data;
        private int _count;
        private int _capacity;
        private int _front = 0, _back = 0;
        #endregion

        #region Constructors
        public MyQueue(): this(8)
        {
        }
        public MyQueue(int capacity)
        {
            this._capacity = capacity;
            _data = new T[capacity];
            _count = 0;
        }

        #endregion


        #region Properties
        public int Count => _count;
        #endregion
        #region Methods
        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
