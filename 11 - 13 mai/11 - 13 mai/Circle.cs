public class Circle
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


}