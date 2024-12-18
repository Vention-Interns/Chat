using HttpChat.Domain;
using System.Collections.Concurrent;

namespace HttpChat.Services
{
    public class ClientService
    {
        private static ConcurrentDictionary<Client, int> clients;
    }
}
