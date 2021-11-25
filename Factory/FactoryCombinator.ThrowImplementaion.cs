namespace Factory;

public static partial class FactoryCombinator
{
    class ThrowImplementaion<TArgs, TResult, TException> : IFactory<TArgs, TResult> where TException : Exception, new()
    {
        public ThrowImplementaion(string message) => _message = message;

        public ThrowImplementaion()
        {
        }

        private readonly string? _message;
        public TResult? CreateInstance(TArgs args)
        {
            if (_message is null)
            {
                throw Activator.CreateInstance(typeof(TException), new[] { _message }) as Exception;
            }
            throw new TException();
        }
    }

}

