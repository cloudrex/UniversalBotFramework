namespace UBF.Core
{
    public interface IChannel
    {
        void Send(Message message);
    }
}
