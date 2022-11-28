using Toranzo.Installer;

namespace Toranzo.Data
{
    public abstract class RepositoryListInstaller<DataType> : MonoInstaller<IRepository<DataType>>
    {
        protected override IRepository<DataType> GetDataType()
        {
            return new RepositoryList<DataType>();
        }
    }
}
