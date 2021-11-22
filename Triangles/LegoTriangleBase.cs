using Core;

namespace Triangles;

public abstract class LegoTriangleBase : LegoShape, IPreConstructionValidation
{

    public Point A { get; private set; }
    public Point B { get; private set; }
    public Point C { get; private set; }

    public double AB => Distance(A, B);

    public double BC => Distance(B, C);

    public double CA => Distance(C, A);

    protected LegoTriangleBase(RgbColor color, Point a, Point b, Point c) : base(color)
    {
        A = a;
        B = b;
        C = c;
    }

    static protected bool TryExtractSides(Point[] point, out (double a, double b, double c) sides)
    {
        if (point.Length == 3)
        {
            var p1 = point[0];
            var p2 = point[1];
            var p3 = point[2];
            sides = (Distance(p1, p2), Distance(p2, p3), Distance(p3, p1));
            return true;
          
        }
        sides = default;
        return false;
    }

    public new static bool CanHavePoints(Point[] points)
    {
        if (TryExtractSides(points, out var sides)) 
        { 
            var (a, b, c) = sides;
            return CanHaveSides(a, b, c);

        }
        else return false;

    }

    protected static bool CanHaveSides(double a, double b, double c)
        => ((a + b > c) || (b + c > a) || (c + a > b)) && !(a.CloseTo(0) || b.CloseTo(0) || c.CloseTo(0));

    protected static double Distance(Point a, Point b)
        => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));


}

