namespace Toranzo.List
{
    public interface IListPresenter<DataType>
    {
        void AddNewItem(DataType dataType);
    }
}