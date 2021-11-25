using Triangles.Shapes;

namespace Triangles.Factories;

class LegoTriangleFactory : TriangleFactoryBase<LegoTriangle>
{
    public LegoTriangleFactory() : base((a, b, c, e) => new LegoTriangle(a, b, c, e))
    {
    }
}

