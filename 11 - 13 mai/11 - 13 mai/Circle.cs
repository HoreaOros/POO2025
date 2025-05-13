public class Circle: Shape
{
    #region Fields
    private Point center;
    private double radius;
    #endregion

    #region Constructors
    public Circle()
    {
        this.center = new Point();
        this.radius = 0.0;
    }

    public Circle(Point center, double radius)
    {
        this.center = center;
        this.radius = radius;
    }
    #endregion

    #region Methods
    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
    #endregion
}