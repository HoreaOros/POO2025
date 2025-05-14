public class Point: ICloneable
{
    #region Fields
    private double x;
    private double y;
    #endregion

    #region Constructors
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Point(): this(0, 0)
    {
    }
    #endregion

    #region Properties
    public double X
    {
        get { return x; }
    }
    public double Y
    {
        get { return y; }
    }
    #endregion
    #region Methods
    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(other.X - this.X, 2) + 
                         Math.Pow(other.Y - this.Y, 2));
    }
    public override string ToString()
    {
        //return "[" + X.ToString() + ", " + Y.ToString() + "]";
        return $"[{X}, {Y}]";
    }

    public object Clone()
    {
        return new Point(this.X, this.Y);
    }
    #endregion
}