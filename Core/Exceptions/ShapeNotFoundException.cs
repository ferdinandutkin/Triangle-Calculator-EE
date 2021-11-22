namespace Core;

public class ShapeNotFoundException : ArgumentException
{
    public ShapeNotFoundException()
    {
    }

    public ShapeNotFoundException(string message)
        : base(message)
    {
    }

    public ShapeNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }

}


