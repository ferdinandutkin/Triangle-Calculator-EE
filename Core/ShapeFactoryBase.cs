namespace Core;

public abstract class ShapeFactoryBase<T> where T : ShapeBase
{
    public abstract T CreateInstance(RgbColor color, params Point[] point);
}

