using Core;
namespace Triangles.Validators;

internal abstract class LegoTriangleValidatorBase : ILegoShapeValidator
{
    public virtual bool CanHavePoints(params Point[] points)
    {
        if (points.Length == 3)
        {
            var p1 = points[0];
            var p2 = points[1];
            var p3 = points[2];

            var pointsLieOnSameXAxis = p1.X.CloseTo(p2.X) && p2.X.CloseTo(p3.X);
            var pointsLieOnSameYAxis = p1.Y.CloseTo(p2.X) && p2.Y.CloseTo(p3.X);
            var pointsAreCollinear = pointsLieOnSameXAxis || pointsLieOnSameYAxis;


            if (!pointsAreCollinear)
            {
                var a = Core.Math.Distance(p1, p2);
                var b = Core.Math.Distance(p2, p3);
                var c = Core.Math.Distance(p3, p1);
                return CanHaveSides(a, b, c);
            }

        }
        return false;
        

    }
    public virtual bool CanHaveSides(double a, double b, double c)
    {
        var oneSideIsBiggerThanSumOfTwoOthers = ((a + b > c) || (b + c > a) || (c + a > b));

        var noSideHasZeroLength = !(a.CloseTo(0) || b.CloseTo(0) || c.CloseTo(0));

        return oneSideIsBiggerThanSumOfTwoOthers && noSideHasZeroLength;

    }


    public abstract bool CanHaveColor(RgbColor color);
  
 
}

