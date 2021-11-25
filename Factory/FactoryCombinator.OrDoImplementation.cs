namespace Factory;

public static partial class FactoryCombinator
{
    public class OrDoImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly Action _action;

        private readonly IFactory<TArgs, TResult> _factory;

        public OrDoImplementation(IFactory<TArgs, TResult> factory, Action action) => (_factory, _action) = (factory, action);

        public TResult? CreateInstance(TArgs args)
        {
            var result = _factory.CreateInstance(args);

            if (result is null)
                _action();

            return result;
        }
 
    }

}

