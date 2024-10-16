namespace MessagingAPI.Services
{
    public class SmsMessage : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Enviando SMS...");
        }
    }
}
