
public class MyStack
{
    #region Fields
    private int[] _stack;
    private int _count; // numarul de elemente din stiva 
    private int _capacity; // numarul total de elemente care incap in stiva
    #endregion

    #region Constructors
    public MyStack(): this(8)
    {
        
    }
    public MyStack(int capacity)
    {
        _count = 0;
        _capacity = capacity;
        _stack = new int[_capacity];
    }
    #endregion

    #region Methods
    public void Push(int value)
    {
        if(_count == _capacity)
        {
            resize(_capacity * 2);
        }
        _stack[_count] = value;
        _count++;
    }
    public int Pop()
    {
        if(_count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        _count--;
        return _stack[_count];
    }
    public int Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack[_count - 1];
    }

    private void resize(int newCapacity)
    {
        int[] newStack = new int[newCapacity];
        //Array.Copy(_stack, newStack, _count);
        for (int i = 0; i < _count; i++)
        {
            newStack[i] = _stack[i];
        }
        _stack = newStack;
        _capacity = newCapacity;
    }
    #endregion

    #region Properties
    public int Count
    {
        get
        {
            return _count;
        }
    }

    public int Capacity => _capacity;
    #endregion
}