namespace Patterns.ChainOfResponsability.GetMessage
{
    public interface IChain : IMessageGetter
    {
        void SetNextChain(IChain chain);
    }
}