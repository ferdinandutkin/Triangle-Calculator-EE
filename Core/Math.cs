namespace Core;

public static class Math
{
    public static double Distance(Point a, Point b)
        => System.Math.Sqrt(System.Math.Pow(a.X - b.X, 2) + System.Math.Pow(a.Y - b.Y, 2));
}

