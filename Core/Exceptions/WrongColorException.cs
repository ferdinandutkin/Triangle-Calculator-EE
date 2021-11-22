namespace Core;

public class WrongColorException : ArgumentException
{
    public WrongColorException()
    {
    }

    public WrongColorException(string message)
        : base(message)
    {
    }

    public WrongColorException(string message, Exception inner)
        : base(message, inner)
    {
    }

}

