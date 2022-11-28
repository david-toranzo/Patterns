using Toranzo.Data;
using Toranzo.Installer;
using UnityEngine;

namespace Toranzo.List
{
    public class ItemListInstaller<DataType> : MonoInstaller<IItemList>
    {
        [SerializeField] private MonoInstaller<IRepository<DataType>> _repositoryList;
        [SerializeField] private MonoInstaller<IListPresenter<DataType>> _listPresenter;

        protected override IItemList GetDataType()
        {
            return new ItemList<DataType>(_repositoryList.Data, _listPresenter.Data);
        }
    }
}