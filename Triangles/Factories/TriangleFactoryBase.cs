using Core;
using Core.Exceptions;
using Triangles.Shapes;

namespace Triangles.Factories;

internal class TriangleFactoryBase<TTriangle> : LegoShapeFactoryBase where TTriangle : LegoTriangle
{

    public delegate TTriangle TriangleConstructor(RgbColor color, Point a, Point b, Point c);

    private readonly TriangleConstructor _constructor;
    protected TriangleFactoryBase(TriangleConstructor constructor) => _constructor = constructor;

    public override LegoShape? CreateInstance(ShapeFactoryArguments arguments)
    {

        var validator = IOC.Validators.Get<TTriangle>();

        if (validator.CanHavePoints(arguments.Points))
        {
            if (validator.CanHaveColor(arguments.Color))
            {
                return _constructor(arguments.Color, arguments.Points[0], arguments.Points[1], arguments.Points[2]);
            }
            else throw new WrongColorException("invalid color provided");
        }
        return null;

    }
}

