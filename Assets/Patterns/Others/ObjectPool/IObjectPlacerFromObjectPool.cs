namespace Toranzo.ObjectPool
{
    public interface IObjectPlacerFromObjectPool<Type>
    {
        Type SpawnSetDisposeTypeAndGetObject(IDisposeType<Type> disposeType);

        void ReturnToObjectPoolObject(Type objectType);
    }
}