using Core.Interfaces;
using Triangles.Shapes;
using Triangles.Validators;

namespace Triangles.IOC;

internal class Validators
{
    private static readonly IReadOnlyDictionary<Type, ILegoShapeValidator> _validators = new Dictionary<Type, ILegoShapeValidator>()
        {
            {typeof(EquilateralLegoTriangle), EquilateralLegoTriangle! },
            {typeof(LegoTriangle), LegoTriangle! },
            {typeof(RectangularLegoTriangle), RectangularLegoTriangle! }

        };

    public static ILegoShapeValidator<EquilateralLegoTriangle> EquilateralLegoTriangle => new EquilateralLegoTriangleValidator();

    public static ILegoShapeValidator<RectangularLegoTriangle> RectangularLegoTriangle => new RectangularLegoTriangleValidator();

    public static ILegoShapeValidator<LegoTriangle> LegoTriangle => new LegoTriangleValidator();

    public static ILegoShapeValidator Get<T>() => _validators[typeof(T)];

    public static ILegoShapeValidator Get(Type type) => _validators[type];
}

