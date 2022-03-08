namespace Twitcher.Interfaces
{
    public interface IMessageReceiverArgs
    {
        public string Channel { get; }
        public string UserName { get; }
        public string Message { get; }
    }
}
