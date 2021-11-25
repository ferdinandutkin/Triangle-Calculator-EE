using Core.Interfaces;

namespace Core;

public abstract class LegoShape : ShapeBase, IGetDisplayName
{

    public RgbColor Color { get; protected set; }

    protected LegoShape(RgbColor color) => Color = color;

    public abstract string DisplayName { get; }

}

