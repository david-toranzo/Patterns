using Toranzo.Installer;
using Toranzo.List.View;
using Toranzo.ObjectPool;
using UnityEngine;

namespace Toranzo.List
{
    public class PresenterListInstaller<DataType> : MonoInstaller<IListPresenter<DataType>>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<IObjectListPlacer> _objectListPlacer;
        [SerializeField] private MonoInstaller<IObjectPool<GameObject>> _objectPoolGameObject;
        [SerializeField] private MonoInstaller<IItemListPresenter<DataType>> _itemListPresenter;

        protected override IListPresenter<DataType> GetDataType()
        {
            return new ListPresenter<DataType>(_objectListPlacer.Data,
                                               _objectPoolGameObject.Data,
                                               _itemListPresenter.Data);
        }
    }
}