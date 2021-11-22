using Core;

namespace Triangles;

public class LegoShapeFactory : LegoShapeFactoryBase
{
    static private bool CanCreate<T>(RgbColor color, params Point[] point) where T : IPreConstructionValidation
    {

        if (T.CanHavePoints(point))
        {
            if (T.CanHaveColor(color))
            {
                return true;
            }
            else throw new WrongColorException($"Invalid color provided for {nameof(T)}");
        }
        return false;
    }

    public override LegoShape CreateInstance(RgbColor color, params Point[] point)
    {
        if (point.Length == 3)
        {
            var p1 = point[0];
            var p2 = point[1];
            var p3 = point[2];

            if (CanCreate<RectangularLegoTriangle>(color, point))
                return new RectangularLegoTriangle(color, p1, p2, p3);

            if (CanCreate<EquilateralLegoTriangle>(color, point))
                return new EquilateralLegoTriangle(color, p1, p2, p3);

            if (CanCreate<LegoTriangle>(color, point))
                return new LegoTriangle(color, p1, p2, p3);

            throw new ArgumentException("Invalid points provided for triangle");

        }
        throw new ShapeNotFoundException("No shape that matches provided point count found");


    }
}

