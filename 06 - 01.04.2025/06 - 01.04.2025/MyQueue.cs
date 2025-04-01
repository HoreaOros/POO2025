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
            if(_count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = _data[_back];
            _back = (_back + 1) % _capacity;
            _count--;
            return item;
        }

        public void Enqueue(T item)
        {
            if(_count == _capacity)
            {
                Resize(2 * _capacity);
            }
            _data[_front] = item;
            _front = (_front + 1) % _capacity;
            _count++;
        }

        private void Resize(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < _count; i++)
            {
                newData[i] = _data[(_back + i) % _capacity];
            }
            _data = newData;
            _back = 0;
            _front = _count;
            _capacity = newCapacity;
        }

        #endregion


    }
}
