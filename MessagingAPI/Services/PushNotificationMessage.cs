namespace MessagingAPI.Services
{
    public class PushNotificationMessage : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Enviando Notificación Push...");
        }
    }
}
