namespace Patterns.ChainOfResponsability.GetMessage
{
    public interface IMessageGetter
    {
        string GetMessageString(ChatMessage chatMessage);
    }
}