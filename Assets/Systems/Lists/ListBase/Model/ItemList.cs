using System.Collections.Generic;
using Toranzo.Data;

namespace Toranzo.List
{
    public class ItemList<DataType> : IItemList
    {
        private IRepository<DataType> _repositoryList;
        private IListPresenter<DataType> _listPresenter;

        public ItemList(IRepository<DataType> repositoryList, IListPresenter<DataType> listPresenter)
        {
            _repositoryList = repositoryList;
            _listPresenter = listPresenter;
        }

        public async void ShowList()
        {
            List<DataType> dataRepositoryList = await _repositoryList.GetAllData();

            for (int i = 0; i < dataRepositoryList.Count; i++)
            {
                _listPresenter.AddNewItem(dataRepositoryList[i]);
            }
        }
    }
}