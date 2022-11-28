namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChainSameUserVerificator : Chain
    {
        private IGetCurrentUser _getUser;

        public ChainSameUserVerificator(IGetCurrentUser getUser)
        {
            _getUser = getUser;
        }

        protected override string GetCorrectStringForThisChain(ChatMessage chatMessage)
        {
            return "<b>" + chatMessage.NameUser + "</b>" + ": " + chatMessage.Message;
        }

        protected override bool IsThisChainTheCorrectOne(ChatMessage chatMessage)
        {
            bool compareUser = string.Equals(_getUser.GetCurrentUser(), chatMessage.NameUser);
            return _getUser.GetCurrentUser() == chatMessage.NameUser;
        }
    }
}