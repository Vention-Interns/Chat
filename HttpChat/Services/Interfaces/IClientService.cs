using HttpChat.API.DTOs;

namespace HttpChat.Services.Interfaces
{
    public interface IClientService
    {
        public Task<ClientDTO> registerClient(string clientName);
    }
}
