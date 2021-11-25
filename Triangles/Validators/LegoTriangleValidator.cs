using Core;
using Core.Interfaces;
using Triangles.Shapes;

namespace Triangles.Validators;

internal class LegoTriangleValidator : LegoTriangleValidatorBase, ILegoShapeValidator<LegoTriangle>
{
    public override bool CanHaveColor(RgbColor color) => true;
}

