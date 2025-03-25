public class MyStack<T>: IStack<T>
{
    private T[] _stack;
    private int _count;
    private int _capacity;

    public MyStack() : this(8)
    {

    }
    public MyStack(int capacity)
    {
        _count = 0;
        _capacity = capacity;
        _stack = new T[_capacity];
    }
    public void Push(T value)
    {
        if (_count == _capacity)
        {
            resize(_capacity * 2);
        }
        _stack[_count] = value;
        _count++;
    }

    private void resize(int newCapacity)
    {
        T[] newStack = new T[newCapacity];
        //Array.Copy(_stack, newStack, _count);
        for (int i = 0; i < _count; i++)
        {
            newStack[i] = _stack[i];
        }
        _stack = newStack;
        _capacity = newCapacity;
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