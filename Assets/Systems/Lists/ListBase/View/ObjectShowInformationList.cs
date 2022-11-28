namespace Toranzo.List.View
{
    public abstract class ObjectShowInformationList<DataType> : IObjectShowInformationList<DataType>
    {
        public abstract void ShowInfoFromAction(DataType listInfo);
    }
}