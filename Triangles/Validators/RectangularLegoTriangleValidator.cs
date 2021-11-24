using Core;

namespace Triangles.Validators;

internal class RectangularLegoTriangleValidator : LegoTriangleValidatorBase, ILegoShapeValidator<RectangularLegoTriangle>
{
    public override bool CanHaveColor(RgbColor color)
        => color == RgbColor.Red || color == RgbColor.Blue;


    public override bool CanHaveSides(double a, double b, double c)
    {
        var asq = a * a;
        var bsq = b * b;
        var csq = c * c;
        var hypotenuseIsEqualToTheSumOfSquaredCathetuses = (bsq + csq).CloseTo(asq) || (csq + asq).CloseTo(bsq) || (bsq + asq).CloseTo(csq);
        return base.CanHaveSides(a, b, c) && hypotenuseIsEqualToTheSumOfSquaredCathetuses;
    }
}

