namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChainOfRenposabilityMessageGetter : IMessageGetter
    {
        private IChain _firstChain;

        public ChainOfRenposabilityMessageGetter(IChain[] chains)
        {
            SetInitialChain(chains);

            SetInitialChains(chains);
        }

        private void SetInitialChain(IChain[] chains)
        {
            if (chains.Length > 0)
                _firstChain = chains[0];
        }

        private void SetInitialChains(IChain[] chains)
        {
            for (int i = 0; i < chains.Length - 1; i++)
            {
                chains[i].SetNextChain(chains[i + 1]);
            }
        }

        public string GetMessageString(ChatMessage chatMessage)
        {
            return _firstChain?.GetMessageString(chatMessage);
        }
    }
}