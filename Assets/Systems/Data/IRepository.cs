using System.Collections.Generic;
using System.Threading.Tasks;

namespace Toranzo.Data
{
    public interface IRepository<DataType>
    {
        void InsertOneData(DataType dataTypeToInsert);
        void DeleteAllData();
        Task<List<DataType>> GetAllData();
    }
}
