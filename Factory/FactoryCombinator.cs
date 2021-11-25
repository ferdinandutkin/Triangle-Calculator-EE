namespace Factory;

public static partial class FactoryCombinator
{

    public static IFactory<TArgs, TResult> If<TArgs, TResult>(Predicate<TArgs> predicate, IFactory<TArgs, TResult> thenFactory, IFactory<TArgs, TResult> elseFactory)
        => new IfImplementation<TArgs, TResult>(predicate, thenFactory, elseFactory);

    public static IFactory<TArgs, TResult> If<TArgs, TResult>(Predicate<TArgs> predicate, IFactory<TArgs, TResult> thenFactory)
        => new IfImplementation<TArgs, TResult>(predicate, thenFactory);

    public static IFactory<TArgs, TResult> Create<TArgs, TResult>(Func<TArgs, TResult> @delegate)
        => new FromDelegateImplementation<TArgs, TResult>(@delegate);

    public static IFactory<TArgs, TResult> OneOf<TArgs, TResult>(params IFactory<TArgs, TResult>[] factories)
        => new OneOfImplementation<TArgs, TResult>(factories);
    public static IFactory<TArgs, TResult> Throw<TArgs, TResult, TException>(this IFactory<TArgs, TResult> factory) where TException : Exception, new()
    => new OrThrowImplementation<TArgs, TResult, TException>(factory);
    public static IFactory<TArgs, TResult> Throw<TArgs, TResult, TException>(this IFactory<TArgs, TResult> factory, string message) where TException : Exception, new()
        => new OrThrowImplementation<TArgs, TResult, TException>(factory, message);

    public static IFactory<TArgs, TResult> OrThrow<TArgs, TResult, TException>(this IFactory<TArgs, TResult> factory) where TException : Exception, new()
        => new OrThrowImplementation<TArgs, TResult, TException>(factory);
    public static IFactory<TArgs, TResult> OrThrow<TArgs, TResult, TException>(this IFactory<TArgs, TResult> factory, string message) where TException : Exception, new()
        => new OrThrowImplementation<TArgs, TResult, TException>(factory, message);

    public static IFactory<TArgs, TResult> Throw<TArgs, TResult, TException>() where TException : Exception, new()
        => new ThrowImplementaion<TArgs, TResult, TException>();
    public static IFactory<TArgs, TResult> Throw<TArgs, TResult, TException>(string message) where TException : Exception, new()
        => new ThrowImplementaion<TArgs, TResult, TException>(message);
    public static IFactory<TArgs, TResult> OrDo<TArgs, TResult>(this IFactory<TArgs, TResult> factory, Action action)  
        => new OrDoImplementation<TArgs, TResult>(factory, action);

    public static IFactory<TArgs, TResult> Or<TArgs, TResult>(this IFactory<TArgs, TResult> firstFactory, IFactory<TArgs, TResult> secondFactory)
        => new OneOfImplementation<TArgs, TResult>(firstFactory, secondFactory);

    public static IFactory<TArgs, TResult> OrOneOf<TArgs, TResult>(this IFactory<TArgs, TResult> factory, params IFactory<TArgs, TResult>[] otherFactories)
        => new OneOfImplementation<TArgs, TResult>(otherFactories.Prepend(factory).ToArray());
 

}

