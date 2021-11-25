namespace Factory;

public static partial class FactoryCombinator
{
    private class FromDelegateImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly Func<TArgs, TResult> _delegate;
        public FromDelegateImplementation(Func<TArgs, TResult> @delegate) => _delegate = @delegate;
        public TResult? CreateInstance(TArgs args) => _delegate(args);

    }

}

