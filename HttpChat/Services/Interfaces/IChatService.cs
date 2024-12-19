using HttpChat.API.DTOs;
using HttpChat.Domain;

namespace HttpChat.Services.Interfaces
{
    public interface IChatService
    {
        public bool addMessageToChat(string clientName, Message message);
    }
}
