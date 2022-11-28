namespace Patterns.ChainOfResponsability.GetMessage
{
    public class ChatMessage
    {
        private string _chatMessage;
        private string _nameUser;

        public ChatMessage(string name, string message)
        {
            NameUser = name;
            _chatMessage = message;
        }
        public string NameUser { get => _nameUser; set => _nameUser = value; }

        public string Message { get => _chatMessage; set => _chatMessage = value; }
    }
}