using Core;

namespace Triangles.Validators;

internal class LegoTriangleValidator : LegoTriangleValidatorBase, ILegoShapeValidator<LegoTriangle>
{
    public override bool CanHaveColor(RgbColor color) => true;
}

