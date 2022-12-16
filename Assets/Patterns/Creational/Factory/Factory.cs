using System.Collections.Generic;

namespace Patterns.Factory
{
    public abstract class Factory<KeyObject, Type> where Type : TypeFactory
    {
        private Dictionary<KeyObject, Type> _factoryIds = new Dictionary<KeyObject, Type>();

        protected void AddObjectToFactory(KeyObject keyObject, Type type)
        {
            _factoryIds.Add(keyObject, type);
        }

        public Type GetObjectType(KeyObject keyObject)
        {
            if (null == keyObject)
                return default;

            if (!_factoryIds.ContainsKey(keyObject))
                throw new System.Exception("The key object doesn't exist");

            return _factoryIds[keyObject];
        }
    }
}