using HttpChat.API.Controllers;
using HttpChat.API.DTOs;
using HttpChat.Domain;
using HttpChat.Services.Interfaces;
using System.Collections.Concurrent;

namespace HttpChat.Services
{
    public class ClientService : IClientService
    {
        private static List<string> clients = new List<string>(){};

        public async Task<ClientDTO> registerClient(string clientName) {
            clients.Add(clientName);
            ClientDTO clientDTO = new ClientDTO("id", clientName);
            return clientDTO;
        }

    }
}
