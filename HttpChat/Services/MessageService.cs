using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using HttpChat.Domain;

namespace HttpChat.Services
{
    public class MessageService
    {
        private static ConcurrentDictionary<Client, SortedList<DateTime, Message>> allMessages;
        private static ConcurrentDictionary<Client, SortedList<DateTime, Message>> newMessages;

    }
}
