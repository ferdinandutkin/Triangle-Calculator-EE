namespace Factory;

public static class FactoryCombinator
{
    class OneOfImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly IFactory<TArgs, TResult>[] _factories;
        public OneOfImplementation(params IFactory<TArgs, TResult>[] factories)
            => _factories = factories;
        public TResult? CreateInstance(TArgs args) => _factories.Select(factory => factory.CreateInstance(args)).FirstOrDefault();

    }



    class FromDelegateImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly Func<TArgs, TResult> _delegate;
        public FromDelegateImplementation(Func<TArgs, TResult> @delegate) => _delegate = @delegate;
        public TResult? CreateInstance(TArgs args) => _delegate(args);

    }


    static IFactory<TArgs, TResult> Or<TArgs, TResult>(this IFactory<TArgs, TResult> firstFactory, IFactory<TArgs, TResult> secondFactory)
        => new OneOfImplementation<TArgs, TResult>(firstFactory, secondFactory);

    static IFactory<TArgs, TResult> OrOneOf<TArgs, TResult>(this IFactory<TArgs, TResult> factory, params IFactory<TArgs, TResult>[] otherFactories)
     => new OneOfImplementation<TArgs, TResult>(otherFactories.Prepend(factory).ToArray());

}

