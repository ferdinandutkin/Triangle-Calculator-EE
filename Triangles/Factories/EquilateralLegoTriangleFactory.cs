using Triangles.Shapes;

namespace Triangles.Factories;

class EquilateralLegoTriangleFactory : TriangleFactoryBase<EquilateralLegoTriangle>
{
    public EquilateralLegoTriangleFactory() : base((a, b, c, e) => new EquilateralLegoTriangle(a, b, c, e))
    {
    }
}

