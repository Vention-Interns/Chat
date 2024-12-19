namespace HttpChat.Domain
{
    public class Client
    {
        public Client(string name) {
            Name = name;
        }
        //private Guid id;
        public string Name { get; private set; }
    }
}
