using UPDSocketChat;
internal class Program
{
    private static void Main(string[] args)
    {
        UDPChat chat = new UDPChat();
        chat.handlerUDPChat();
    }
}