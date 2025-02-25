using System.Runtime.InteropServices;

internal class Point
{
    private float x;
    private float y;

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }


    public float ManhattanDistanceTo(Point p2)
    {
        return Math.Abs(x - p2.x) + Math.Abs(y - p2.y);
    }

    public float EuclideanDistanceTo(Point p2)
    {
        return (float)Math.Sqrt(Math.Pow(x - p2.x, 2) +  Math.Pow(y - p2.y, 2));   
    }
}