namespace Twitcher.Interfaces
{
    public interface ITwitchChatClient
    {
        event EventHandler<EventArgs>? OnConnected;
        event EventHandler<EventArgs>? OnReconnected;
        event EventHandler<IMessageReceiverArgs>? OnMessageReceived;

        void Connect();
        void Disconnect();

        void AddChannel(string username);
        void RemoveChannel(string username);

        void SendMessage(string channel, string message);

    }
}
