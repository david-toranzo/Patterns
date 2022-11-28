using UnityEngine;

namespace Toranzo.List.View
{
    public interface IItemListPresenter<DataType>
    {
        public void AddNewItem(IViewItemList viewItem, DataType item);
    }
}