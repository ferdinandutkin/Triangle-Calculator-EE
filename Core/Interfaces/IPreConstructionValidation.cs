namespace Core;

public interface IPreConstructionValidation
{
    static abstract bool CanHavePoints(Point[] point);

    static abstract bool CanHaveColor(RgbColor color);
}

