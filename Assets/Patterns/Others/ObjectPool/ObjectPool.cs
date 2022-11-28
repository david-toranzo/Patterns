using System.Collections.Generic;

namespace Toranzo.ObjectPool
{
    public class ObjectPool<Type> : IObjectPool<Type>
    {
        private Queue<Type> _objectActivatedInScene;
        private Queue<Type> _objectDesactivatedInScene;

        private IObjectPlacerFromObjectPool<Type> _placerObject;

        public ObjectPool(IObjectPlacerFromObjectPool<Type> spawnObject)
        {
            _placerObject = spawnObject;

            _objectActivatedInScene = new Queue<Type>();
            _objectDesactivatedInScene = new Queue<Type>();
        }

        public void DisposeType(Type typeObject)
        {
            _placerObject.ReturnToObjectPoolObject(typeObject);
            _objectDesactivatedInScene.Enqueue(typeObject);
        }

        public Type GetObjectPoolType()
        {
            Type typeObject = GetOtherObjectFromNotUseObjects();

            _objectActivatedInScene.Enqueue(typeObject);
            return typeObject;
        }

        private Type GetOtherObjectFromNotUseObjects()
        {
            Type typeObject;

            if (_objectDesactivatedInScene.Count > 0)
                typeObject = _objectDesactivatedInScene.Dequeue();
            else
                typeObject = _placerObject.SpawnSetDisposeTypeAndGetObject(this);

            return typeObject;
        }
    }
}