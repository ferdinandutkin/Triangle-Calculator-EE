namespace Factory;

public static partial class FactoryCombinator
{
    private class OneOfImplementation<TArgs, TResult> : IFactory<TArgs, TResult>
    {
        private readonly IFactory<TArgs, TResult>[] _factories;
        public OneOfImplementation(params IFactory<TArgs, TResult>[] factories)
            => _factories = factories;
        public TResult? CreateInstance(TArgs args) => _factories.Select(factory => factory.CreateInstance(args)).Where(instance => instance is not null).FirstOrDefault();
    
        

    }

}

