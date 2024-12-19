namespace HttpChat.API.DTOs
{
    public class ClientMessageDTO
    {
        //private string token;
        public ClientMessageDTO(string cName, string mText) {
            ClientName = cName;
            MessageText = mText;
        }
        public string ClientName { get; private set; }
        public string MessageText { get; private set; }
    }
}
