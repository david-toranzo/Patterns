using UnityEngine;

namespace Patterns.Observer
{
    [CreateAssetMenu(fileName = "DataEvent", menuName = "ScriptableObjects/Patterns/Observer/DataType", order = 0)]
    public class DataTypeObserverPattern : ScriptableObject, INameObserverGetter
    {
        [SerializeField] private string _typeNameObserver;

        public string GetTypeNameObserver() => _typeNameObserver;
    }
}