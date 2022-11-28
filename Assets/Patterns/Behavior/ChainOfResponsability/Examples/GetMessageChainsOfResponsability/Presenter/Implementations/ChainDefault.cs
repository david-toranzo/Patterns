namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChainDefault : Chain
    {
        protected override string GetCorrectStringForThisChain(ChatMessage chatMessage)
        {
            return chatMessage.NameUser + ": " + chatMessage.Message;
        }

        protected override bool IsThisChainTheCorrectOne(ChatMessage chatMessage)
        {
            return true;
        }
    }
}