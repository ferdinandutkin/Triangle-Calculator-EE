namespace Core;

public class Lego
{
    LegoShapeFactoryBase _factory;
    public Lego(LegoShapeFactoryBase factory)
    {
        _factory = factory;
    }

    public string GetShapeDisplayName(RgbColor color, params Point[] points)
        => _factory.CreateInstance(color, points).DisplayName;

    public double GetShapeArea(RgbColor color, params Point[] points)
      => _factory.CreateInstance(color, points).Area;

    public string GetShapeInformation(RgbColor color, params Point[] points)
    {
        var instance = _factory.CreateInstance(color, points);
        return $"{instance.DisplayName} {instance.Area}"; 

    }
}

