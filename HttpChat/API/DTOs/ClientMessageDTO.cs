namespace HttpChat.API.DTOs
{
    public class ClientMessageDTO
    {
        //private string token;
        public ClientMessageDTO(string cName, string mText, DateTime time) {
            ClientName = cName;
            MessageText = mText;
            CreationTime = time;
        }
        public string ClientName { get; private set; }
        public string MessageText { get; private set; }
        public DateTime CreationTime { get; private set; }
    }
}
