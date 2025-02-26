internal class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public double EuclideanDistance(Point p2)
    {
        if (p2 == null)
            throw new ArgumentNullException("Invalid Point");

        return Math.Sqrt(Math.Pow(Math.Abs(x - p2.x),2) + 
            Math.Pow(Math.Abs(y - p2.y),2));
    }

    public double ManhattanDistance(Point p2)
    {
        if (p2 == null)
            throw new ArgumentNullException("Invalid Point");

        return Math.Abs(x - p2.x) + Math.Abs(y - p2.y);
    }
}