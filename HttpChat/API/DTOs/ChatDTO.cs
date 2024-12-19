using System.Collections.Concurrent;
using HttpChat.Domain;

namespace HttpChat.API.DTOs
{
    public class ChatDTO
    {
        public SortedList<DateTime, ClientMessageDTO> Chat { get; set; }
    }
}
