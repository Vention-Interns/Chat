using HttpChat.API.DTOs;
using HttpChat.Domain;
using HttpChat.Services.Interfaces;

namespace HttpChat.Services
{
    public class ChatService : IChatService
    {
        private static SortedList<DateTime, Message> allMessages = new SortedList<DateTime, Message> { };
        private static SortedList<DateTime, Message> newMessages = new SortedList<DateTime, Message> { };
        public bool addMessageToChat(string clientName, Message message)
        {
            allMessages.Add(message.CreationTime, message);
            return true;
        }
    }
}
