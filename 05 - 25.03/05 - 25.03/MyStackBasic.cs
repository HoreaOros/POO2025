using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyStackBasic<T> : IStack<T>
{
    private T[] _stack;
    private int _count;
    private int _capacity;

    public MyStackBasic() : this(8)
    {

    }
    public MyStackBasic(int capacity)
    {
        _count = 0;
        _capacity = capacity;
        _stack = new T[_capacity];
    }
    public void Push(T value)
    {
        if (_count == _capacity)
        {
            throw new InvalidOperationException("Stiva este plina");
        }
        _stack[_count] = value;
        _count++;
    }



    public T Pop()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        _count--;
        return _stack[_count];
    }
    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_count - 1];
    }
    public int Count
    {
        get
        {
            return _count;
        }
    }

    public int Capacity => _capacity;
}
