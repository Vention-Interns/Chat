using HttpChat.API.Controllers;
using HttpChat.API.DTOs;
using HttpChat.Domain;
using HttpChat.Services.Interfaces;
using System.Collections.Concurrent;

namespace HttpChat.Services
{
    public class ClientService : IClientService
    {
        private static ConcurrentDictionary<string, int> clients = new ConcurrentDictionary<string, int>(){};

        public async Task<ClientDTO> registerClient(string clientName) {
            clients.AddOrUpdate(clientName, 0, (key, oldValue) =>0);
            ClientDTO clientDTO = new ClientDTO("hej", clientName);
            return clientDTO;
        }

    }
}
