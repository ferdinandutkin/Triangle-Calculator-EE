using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public abstract class LegoShape : ShapeBase, IGetDisplayName, IPreConstructionValidation
{


    public RgbColor Color { get; private set; }

    protected LegoShape(RgbColor color) => Color = color;

    public abstract string DisplayName { get; }

    public static bool CanHaveColor(RgbColor color) => true;

    public static bool CanHavePoints(Point[] point) => true;
}

