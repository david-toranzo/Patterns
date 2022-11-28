using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.List
{
    public class ObjectListPlacerInstaller : MonoInstaller<IObjectListPlacer>
    {
        [SerializeField] private Transform _gameObjectToPlace;

        protected override IObjectListPlacer GetDataType()
        {
            return new ObjectListPlacer(_gameObjectToPlace);
        }
    }
}