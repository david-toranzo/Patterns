using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.ObjectPool
{
    public class ObjectPoolInstaller<Type> : MonoInstaller<IObjectPool<Type>>
    {
        [SerializeField] private MonoInstaller<IObjectPlacerFromObjectPool<Type>> _installerSpawnObject;

        protected override IObjectPool<Type> GetDataType()
        {
            return new ObjectPool<Type>(_installerSpawnObject.Data);
        }
    }
}