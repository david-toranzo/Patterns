namespace Toranzo.ObjectPool
{
    public abstract class ObjectPlacerFromObjectPool<Type> : IObjectPlacerFromObjectPool<Type>
    {
        public abstract void ReturnToObjectPoolObject(Type objectType);
        public abstract Type SpawnSetDisposeTypeAndGetObject(IDisposeType<Type> disposeType);
    }
}