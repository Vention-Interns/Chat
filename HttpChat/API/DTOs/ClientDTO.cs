namespace HttpChat.API.DTOs
{
    public class ClientDTO
    {
        public string Id { get; private set; }
        public string Token { get; private set; }
        public ClientDTO(string id, string token)
        {
            Id = id;
            Token = token;
        }
    }
}
