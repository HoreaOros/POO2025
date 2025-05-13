public class Rectangle
{
    #region Fields
    private Point p1;
    private Point p2;
    #endregion

    #region Constructors
    public Rectangle(Point p1, Point p2) 
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    public Rectangle()
    {
        this.p1 = new Point();
        this.p2 = new Point();
    }

    public Rectangle(Point origin, double width, double height)
    {
        this.p1 = origin;
        this.p2 = new Point(origin.X + width, origin.Y + height);
    }
    #endregion

    #region Properties
    public Point P1
    {
        get { return p1; }
    }
    public Point P2
    {
        get { return p2; }
    }

    public double Width
    {
        get { return Math.Abs(p2.X - p1.X); }
    }
    public double Height
    {
        get { return Math.Abs(p2.Y - p1.Y); }
    }
    public Point Origin
    {
        get 
        {
            return new Point( Math.Min(p1.X, p2.X),
                              Math.Min(p1.Y, p2.Y)); 
        }
    }
    #endregion
}