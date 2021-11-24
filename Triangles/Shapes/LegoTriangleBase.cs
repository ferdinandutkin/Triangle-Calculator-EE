using Core;

namespace Triangles;

public abstract class LegoTriangleBase : LegoShape
{

    public Point A { get; private set; }
    public Point B { get; private set; }
    public Point C { get; private set; }

    public double AB => Core.Math.Distance(A, B);

    public double BC => Core.Math.Distance(B, C);

    public double CA => Core.Math.Distance(C, A);

    protected LegoTriangleBase(RgbColor color, Point a, Point b, Point c) : base(color)
    {
        var validator = IOC.Validators.Get(GetType());

        if (!validator.CanHavePoints(a, b, c))
        {
            throw new ArgumentException("Invalid points provided");
        }
        if (!validator.CanHaveColor(color))
        {
            throw new ArgumentException("Invalid color provided");
        }     

        A = a;
        B = b;
        C = c;

        Color = color;
    }


 


}

