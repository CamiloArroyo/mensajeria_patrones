namespace MessagingAPI.Services
{
    public class EmailMessage : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Enviando correo electrónico...");
        }
    }
}
