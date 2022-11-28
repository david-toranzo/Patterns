using UnityEngine;

namespace Toranzo.ObjectPool
{
    public class PlaceObjectFromObjectPoolGameObject : ObjectPlacerFromObjectPool<GameObject>
    {
        private GameObject _gameObjectToSpawn;
        private Transform _parentObjectWhenDesactive;

        public PlaceObjectFromObjectPoolGameObject(GameObject gameObjectToSpawn, Transform parentObjectWhenDesactive)
        {
            _gameObjectToSpawn = gameObjectToSpawn;
            _parentObjectWhenDesactive = parentObjectWhenDesactive;
        }

        public override void ReturnToObjectPoolObject(GameObject objectType)
        {
            objectType.transform.SetParent(_parentObjectWhenDesactive);
        }

        public override GameObject SpawnSetDisposeTypeAndGetObject(IDisposeType<GameObject> disposeType)
        {
            GameObject prefabInstance = GameObject.Instantiate(_gameObjectToSpawn);
            prefabInstance.GetComponent<IObjectPoolInstance<GameObject>>().AddNewDisposeType(disposeType);

            return prefabInstance;
        }
    }
}