namespace Toranzo.ObjectPool
{
    public interface IDisposeType<Type>
    {
        void DisposeType(Type typeObject);
    }
}