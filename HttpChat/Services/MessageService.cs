using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using HttpChat.Domain;
using HttpChat.Services.Interfaces;

namespace HttpChat.Services
{
    public class MessageService : IMessageService
    {
        private static ConcurrentDictionary<Client, SortedList<DateTime, Message>> allMessages;
        private static ConcurrentDictionary<Client, SortedList<DateTime, Message>> newMessages;

    }
}
