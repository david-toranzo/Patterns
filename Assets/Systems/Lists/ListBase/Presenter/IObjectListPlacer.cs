using UnityEngine;

namespace Toranzo.List
{
    public interface IObjectListPlacer
    {
        void SetObjectToPlace(GameObject gameObjectToSet);
        void DisposeAllElements();
    }
}