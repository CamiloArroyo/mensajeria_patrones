namespace MessagingAPI.Services
{
    public class MessageFactory
    {
        public static IMessage CreateMessage(string messageType)
        {
            switch (messageType)
            {
                case "Email":
                    return new EmailMessage();
                case "SMS":
                    return new SmsMessage();
                case "Push":
                    return new PushNotificationMessage();
                default:
                    throw new ArgumentException("Tipo de mensaje no soportado.");
            }
        }
    }
}
