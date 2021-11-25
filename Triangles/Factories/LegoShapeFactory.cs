using Core;
using Core.Exceptions;
using Factory;

namespace Triangles.Factories;

public class LegoShapeFactory : LegoShapeFactoryBase
{

    private readonly IFactory<ShapeFactoryArguments, LegoShape> _factory =
          FactoryCombinator.If(args => args.Points.Length == 3,
               FactoryCombinator
                  .OneOf(new EquilateralLegoTriangleFactory(), new RectangularLegoTriangleFactory(), new LegoTriangleFactory())
                  .OrThrow<ShapeFactoryArguments, LegoShape, ArgumentException>("invalid points provided for triagle"),
               FactoryCombinator.Throw<ShapeFactoryArguments, LegoShape, ShapeNotFoundException>("No shape that matches provided point count found"));


 
                 


    public override LegoShape CreateInstance(ShapeFactoryArguments arguments) => _factory.CreateInstance(arguments);

}

