using Core;
using Triangles.Validators;

namespace Triangles.IOC;

internal class Validators
{

    static readonly IReadOnlyDictionary<Type, ILegoShapeValidator> _validators = new Dictionary<Type, ILegoShapeValidator>()
        {
            {typeof(EquilateralLegoTriangle), EquilateralLegoTriangle! },
            {typeof(LegoTriangle), LegoTriangle! },
            {typeof(RectangularLegoTriangle), RectangularLegoTriangle! }

        };

    public static ILegoShapeValidator<EquilateralLegoTriangle> EquilateralLegoTriangle { get; } = new EquilateralLegoTriangleValidator();

    public static ILegoShapeValidator<RectangularLegoTriangle> RectangularLegoTriangle { get; } = new RectangularLegoTriangleValidator();

    public static ILegoShapeValidator<LegoTriangle> LegoTriangle { get; } = new LegoTriangleValidator();

    public static ILegoShapeValidator Get<T>() => _validators[typeof(T)];

    public static ILegoShapeValidator Get(Type type) => _validators[type];
}

