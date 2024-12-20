using HttpChat.API.DTOs;

namespace HttpChat.Services.Interfaces
{
    public interface IMessageService
    {
        public Task<bool> sendMessage(ClientMessageDTO clientMessageDTO);
    }
}
