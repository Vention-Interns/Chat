namespace HttpChat.API.DTOs
{
    public class ClientMessageDTO
    {
        //private string token;
        public ClientMessageDTO(string clientName, string messageText, DateTime creationTime)
        {
            ClientName = clientName;
            MessageText = messageText;
            CreationTime = creationTime;
        }

        public string ClientName { get; private set; }
        public string MessageText { get; private set; }
        public DateTime CreationTime { get; private set; }
    }
}
