using Core;

namespace Triangles;

public class RectangularLegoTriangle : LegoTriangle, IPreConstructionValidation
{
    public override string DisplayName => nameof(TriangleType.Rectangular);

    public override double Area
    {
        get
        {
            var asq = AB * AB;
            var bsq = BC * BC;
            var csq = CA * CA;

            if (asq.CloseTo(bsq + csq))
            {
                return BC * CA;
            }
            else if (bsq.CloseTo(asq + csq))
            {
                return AB * CA;
            }
            else return AB * BC;
        }
    }


    public RectangularLegoTriangle(RgbColor color, Point a, Point b, Point c) : base(color, a, b, c)
    {
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

    public static new bool CanHaveSides(double a, double b, double c)
    {
        var asq = a * a;
        var bsq = b * b;
        var csq = c * c;
        return LegoTriangle.CanHaveSides(a, b, c) &&  ((bsq + csq).CloseTo(asq) || (csq + asq).CloseTo(bsq) || (bsq + asq).CloseTo(csq));
    }
         

    public static new bool CanHaveColor(RgbColor color)
         => color == RgbColor.Red || color == RgbColor.Blue;


}

