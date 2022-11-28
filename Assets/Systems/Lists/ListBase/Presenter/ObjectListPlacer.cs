using Toranzo.ObjectPool;
using UnityEngine;

namespace Toranzo.List
{
    public class ObjectListPlacer : IObjectListPlacer
    {
        private Transform _gameObjectToPlace;

        public ObjectListPlacer(Transform gameObjectToPlace)
        {
            _gameObjectToPlace = gameObjectToPlace;
        }

        public void SetObjectToPlace(GameObject gameObjectToSet)
        {
            gameObjectToSet.transform.SetParent(_gameObjectToPlace.transform);
        }

        public void DisposeAllElements()
        {
            var objectsElements = _gameObjectToPlace.GetComponentsInChildren<IObjectPoolInstance<GameObject>>();

            foreach (var item in objectsElements)
            {
                item.Dispose();
            }
        }
    }
}