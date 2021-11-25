namespace Factory;

public static partial class FactoryCombinator
{
    private class IfImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly Predicate<TArgs> _predicate;
        private readonly IFactory<TArgs, TResult> _thenFactory;
        private readonly IFactory<TArgs, TResult>? _elseFactory;
        public IfImplementation(Predicate<TArgs> predicate, IFactory<TArgs, TResult> thenFactory, IFactory<TArgs, TResult> elseFactory)
        {
            _predicate = predicate;
            _thenFactory = thenFactory;
            _elseFactory = elseFactory;
        }

        public IfImplementation(Predicate<TArgs> predicate, IFactory<TArgs, TResult> thenFactory) : this(predicate, thenFactory, null)
        {
 
        }

        public TResult? CreateInstance(TArgs args)
        {
            if (_predicate(args))
                return _thenFactory.CreateInstance(args);
            if (_elseFactory is null)
                return default;

            return _elseFactory.CreateInstance(args);
     
        }
           
    }

}

