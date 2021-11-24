using Core;

namespace Triangles.Validators;

internal class EquilateralLegoTriangleValidator : LegoTriangleValidatorBase, ILegoShapeValidator<EquilateralLegoTriangle>
{
    public override bool CanHaveSides(double a, double b, double c)
    {
        var allSidesAreEqual = a.CloseTo(b) && b.CloseTo(c);
        return base.CanHaveSides(a, b, c) && allSidesAreEqual;
    }
    public override bool CanHaveColor(RgbColor color)
        => color == RgbColor.Red || color == RgbColor.Blue || color == RgbColor.White || color == RgbColor.Green;

}

