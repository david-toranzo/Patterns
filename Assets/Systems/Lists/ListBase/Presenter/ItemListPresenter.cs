namespace Toranzo.List.View
{
    public abstract class ItemListPresenter<DataType> : IItemListPresenter<DataType>
    {
        private IObjectShowInformationList<DataType> _objectShowInformation;

        public ItemListPresenter(IObjectShowInformationList<DataType> objectShowInformation)
        {
            _objectShowInformation = objectShowInformation;
        }

        public void AddNewItem(IViewItemList viewItem, DataType item)
        {
            viewItem.OnClickList += () =>
            {
                _objectShowInformation.ShowInfoFromAction(item);
            };

            SetInformationToItem(viewItem, item);
        }

        protected abstract void SetInformationToItem(IViewItemList itemView, DataType item);
    }
}