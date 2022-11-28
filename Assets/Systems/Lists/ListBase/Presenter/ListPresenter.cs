using Toranzo.List.View;
using Toranzo.ObjectPool;
using UnityEngine;

namespace Toranzo.List
{
    public class ListPresenter<DataType> : IListPresenter<DataType>
    {
        private IObjectListPlacer _objectListPlacer;

        private IObjectPool<GameObject> _objectPoolGameObject;
        private IItemListPresenter<DataType> _itemListPresenter;

        public ListPresenter(IObjectListPlacer objectListPlacer,
                             IObjectPool<GameObject> objectPoolGameObject,
                             IItemListPresenter<DataType> viewList)
        {
            _objectListPlacer = objectListPlacer;
            _objectPoolGameObject = objectPoolGameObject;
            _itemListPresenter = viewList;
        }

        public void AddNewItem(DataType dataType)
        {
            GameObject goItemList = _objectPoolGameObject.GetObjectPoolType();
            goItemList.SetActive(true);

            _objectListPlacer.SetObjectToPlace(goItemList);

            IViewItemList viewItem = GetDataItemView(goItemList);

            _itemListPresenter.AddNewItem(viewItem, dataType);
        }

        private IViewItemList GetDataItemView(GameObject goItemList)
        {
            return goItemList.GetComponent<IViewItemList>();
        }
    }
}