using Factory;

namespace Core;

public abstract class ShapeFactoryBase<T> : IFactory<ShapeFactoryArguments, T> where T : ShapeBase
{
    public abstract T? CreateInstance(RgbColor color, params Point[] point);

    public T? CreateInstance(ShapeFactoryArguments args) => CreateInstance(args.Color, args.Point);

}

