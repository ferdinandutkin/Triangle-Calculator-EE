namespace Core
{
    public interface ILegoShapeValidator
    {
        bool CanHavePoints(params Point[] point);

        bool CanHaveColor(RgbColor color);
    }


    public interface ILegoShapeValidator<T> : ILegoShapeValidator
    {

    }
}
