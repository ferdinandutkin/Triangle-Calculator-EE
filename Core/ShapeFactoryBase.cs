using Factory;

namespace Core;

public abstract class ShapeFactoryBase<T> : IFactory<ShapeFactoryArguments, T> where T : ShapeBase
{
    public T? CreateInstance(RgbColor color, params Point[] points) => CreateInstance(new ShapeFactoryArguments(color, points));

    public abstract T? CreateInstance(ShapeFactoryArguments args);

}

