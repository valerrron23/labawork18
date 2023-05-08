namespace UDPClientChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UDPChat uDPChat = new UDPChat();
            uDPChat.handlerChat();
        }
    }
}