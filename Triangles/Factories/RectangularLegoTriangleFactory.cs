using Triangles.Shapes;

namespace Triangles.Factories;

class RectangularLegoTriangleFactory : TriangleFactoryBase<RectangularLegoTriangle>
{
    public RectangularLegoTriangleFactory() : base((a, b, c, e) => new RectangularLegoTriangle(a, b, c, e))
    {
    }
}

