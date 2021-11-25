using Core;

namespace Triangles.Shapes;

public class LegoTriangle : LegoTriangleBase
{

    public override string DisplayName => nameof(TriangleType.Basic);

    public override double Area
    {
        get
        {
            var p = (AB + BC + CA) / 2;
            return System.Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
        }
    }

    public LegoTriangle(RgbColor color, Point a, Point b, Point c) : base(color, a, b, c)
    {

    }


}



