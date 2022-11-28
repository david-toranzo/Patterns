namespace Services.Core
{
    public interface IService<DataType>
    {
        void Send(DataType data);
    }
}