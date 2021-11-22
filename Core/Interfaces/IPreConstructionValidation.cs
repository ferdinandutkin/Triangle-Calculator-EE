namespace Core;

public interface IPreConstructionValidation
{
    static abstract bool CanHavePoints(params Point[] point);

    static abstract bool CanHaveColor(RgbColor color);
}

