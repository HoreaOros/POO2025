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
    public Shape()
    {
        this.color = Color.Black;
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
    }
    #endregion

    #region Methods
    public abstract double Area();
    public abstract double Perimeter();
    #endregion
}