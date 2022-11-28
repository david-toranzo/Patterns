using System.Collections.Generic;
using System.Threading.Tasks;
using Toranzo.Data;

namespace Toranzo.Data
{
    public class RepositoryList<DataType> : IRepository<DataType>
    {
        private List<DataType> _dataRepositoryList;

        public RepositoryList()
        {
            _dataRepositoryList = new List<DataType>();
        }

        public void DeleteAllData()
        {
            _dataRepositoryList.Clear();
        }

        public async Task<List<DataType>> GetAllData()
        {
            await Task.Yield();
            return _dataRepositoryList;
        }

        public void InsertOneData(DataType dataTypeToInsert)
        {
            _dataRepositoryList.Add(dataTypeToInsert);
        }
    }
}