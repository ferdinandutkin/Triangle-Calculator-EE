using Core;

namespace Triangles.Shapes;

public class EquilateralLegoTriangle : LegoTriangle
{
    public EquilateralLegoTriangle(RgbColor color, Point a, Point b, Point c) : base(color, a, b, c)
    {

    }

    public override string DisplayName => nameof(TriangleType.Equilateral);


    public override double Area => System.Math.Pow(AB, 2) * System.Math.Sqrt(3) / 4;


}