using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using HttpChat.API.DTOs;
using HttpChat.Domain;
using HttpChat.Services.Interfaces;

namespace HttpChat.Services
{
    public class MessageService : IMessageService
    {
        private readonly IChatService _chatService;
        private static Dictionary<string, List<Message>> clientMessages = new Dictionary<string, List<Message>>() { };

        public MessageService(IChatService chatService) {
            this._chatService = chatService;
        }
        public async Task<bool> sendMessage(ClientMessageDTO clientMessageDTO) {
            Message message = new Message(clientMessageDTO.MessageText, clientMessageDTO.ClientName, clientMessageDTO.CreationTime);
            string clientName = clientMessageDTO.ClientName;
            if (!clientMessages.ContainsKey(clientName)) {
                clientMessages[clientName] = new List<Message>();
            }
            clientMessages[clientName].Add(message);
            _chatService.addMessageToChat(clientName, message);

            return true;
        }

    }
}
