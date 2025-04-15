﻿// See https://aka.ms/new-console-template for more information

public class Counter
{
    #region Fields
    protected int _count = 0;
    private int _step = 1;
    #endregion

    #region Properties
    public int Count => _count; 
    #endregion

    #region Constructors
    public Counter(): this(0)
    {
    }
    public Counter(int count): this(count, 1)
    {
    }

    public Counter(int count, int step)
    {
        _count = count;
        _step = step;
    }
    #endregion

    #region Methods
    public virtual void Tick()
    {
        _count += _step;
    }
    public void Reset()
    {
        _count = 0;
    }
    //public void Decrement()
    //{
    //    _count--;
    //}

    public override string ToString()
    {
        return $"[Count: {_count}]";
    }
    #endregion

}