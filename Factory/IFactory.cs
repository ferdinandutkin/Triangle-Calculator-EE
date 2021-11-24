namespace Factory;

public interface IFactory<TArgs, TResult>
{
    TResult? CreateInstance(TArgs args);
}
