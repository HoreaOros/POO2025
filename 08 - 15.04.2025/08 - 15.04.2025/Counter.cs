// See https://aka.ms/new-console-template for more information

public class Counter
{
    #region Fields
    protected int _count = 0;
    protected int _step = 1;
    #endregion

    #region Properties
    public int Count => _count; 
    public int Step => _step; 
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
        Tick(_step);
    }
    public virtual void Tick(int step)
    {
        _count += step;
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
        return $"[Count: {_count}, Step: {_step}]";
    }
    #endregion

}