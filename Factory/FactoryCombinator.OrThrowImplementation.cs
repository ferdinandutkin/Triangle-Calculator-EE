namespace Factory;

public static partial class FactoryCombinator
{
    private class OrThrowImplementation<TArgs, TResult, TException> : IFactory<TArgs, TResult> where TException : Exception, new()
    {
        private readonly IFactory<TArgs, TResult> _factory;
        private readonly string? _message;

        public OrThrowImplementation(IFactory<TArgs, TResult> factory)
            => _factory = factory;


       
        public OrThrowImplementation(IFactory<TArgs, TResult> factory, string message) : this(factory)
          => _message = message;


        public TResult CreateInstance(TArgs args)
        {

            var result = _factory.CreateInstance(args);
            
            if (result is not null)
            {
                return result;
            }

            if (result is null && _message is null)
            {
                throw Activator.CreateInstance(typeof(TException), new[] { _message }) as Exception;
            }
            throw new TException();
        
          
        }
    }       

}

