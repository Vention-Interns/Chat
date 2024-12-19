using System.Xml;

namespace HttpChat.Domain
{
    public class Message
    {
        //private Guid id;
        public string Text { get; private set; }
        public string SenderName { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Message(string text, string senderName, DateTime time) {
            Text = text;
            SenderName = senderName;
            CreationTime = time;
        }
    }
}
