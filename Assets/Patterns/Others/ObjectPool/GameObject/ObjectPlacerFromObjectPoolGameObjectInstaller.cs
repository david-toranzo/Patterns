using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.ObjectPool
{
    public class ObjectPlacerFromObjectPoolGameObjectInstaller : MonoInstaller<IObjectPlacerFromObjectPool<GameObject>>
    {
        [SerializeField] private GameObject _gameObjectToSpawn;
        [SerializeField] private Transform _transformParentDesactive;

        protected override IObjectPlacerFromObjectPool<GameObject> GetDataType()
        {
            return new PlaceObjectFromObjectPoolGameObject(_gameObjectToSpawn, _transformParentDesactive);
        }
    }
}