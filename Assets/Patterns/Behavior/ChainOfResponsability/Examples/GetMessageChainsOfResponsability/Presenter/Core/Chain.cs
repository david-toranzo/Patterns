namespace Patterns.ChainOfResponsability.GetMessage
{
    public abstract class Chain : IChain
    {
        private IChain _nextChain;

        public void SetNextChain(IChain chain)
        {
            _nextChain = chain;
        }

        public string GetMessageString(ChatMessage chatMessage)
        {
            if (IsThisChainTheCorrectOne(chatMessage))
                return GetCorrectStringForThisChain(chatMessage);

            return _nextChain.GetMessageString(chatMessage);
        }

        protected abstract bool IsThisChainTheCorrectOne(ChatMessage chatMessage);

        protected abstract string GetCorrectStringForThisChain(ChatMessage chatMessage);

    }
}