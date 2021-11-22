using Core;

namespace Triangles;

public class EquilateralLegoTriangle : LegoTriangle, IPreConstructionValidation
{
    public EquilateralLegoTriangle(RgbColor color, Point a, Point b, Point c) : base(color, a, b, c)
    {
    }

    public override string DisplayName => nameof(TriangleType.Equilateral);


    public override double Area => Math.Pow(AB, 2) * Math.Sqrt(3) / 4;

    public new static bool CanHavePoints(Point[] points)
    {
        if (TryExtractSides(points, out var sides))
        {
            var (a, b, c) = sides;
            return CanHaveSides(a, b, c);

        }
        else return false;

    }
    public static new bool CanHaveSides(double a, double b, double c)
        => LegoTriangle.CanHaveSides(a, b, c) && (a.CloseTo(b) && a.CloseTo(c));


    public new bool CanHaveColor(RgbColor color)
         => color == RgbColor.Red || color == RgbColor.Blue || color == RgbColor.White || color == RgbColor.Green;
}

