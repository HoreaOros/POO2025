public enum Color
{
    Red, 
    Green,
    Blue,
    Black,
    White,
    Yellow
}


public abstract class Shape
{
    #region Fields
    protected Color color;
    #endregion

    #region Constructors
    public Shape(): this(Color.Black)
    {
    }
    
    public Shape(Color color)
    {
        this.color = color;
    }
    #endregion

    #region Properties
    public Color Color
    {
        get { return color; }
        set { color = value; }
    }
    #endregion

    #region Methods
    public abstract double Area();
    public abstract double Perimeter();
    public void Draw()
    {
        Console.WriteLine($"Drawing {this.GetType().Name} {this}");
    }
    #endregion
}