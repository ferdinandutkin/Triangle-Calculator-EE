using Core;

namespace Triangles.Shapes;

public class RectangularLegoTriangle : LegoTriangle
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



}

