namespace Toranzo.ObjectPool
{
    public interface IObjectPool<Type> : IDisposeType<Type>
    {
        Type GetObjectPoolType();
    }
}