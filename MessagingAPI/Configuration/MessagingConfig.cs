namespace MessagingAPI.Configuration
{
    public class MessagingConfig
    {
        private static MessagingConfig _instance;
        private static readonly object _lock = new object();

        public string EmailServiceApiKey { get; private set; }
        public string SmsServiceApiKey { get; private set; }
        public string PushNotificationServiceApiKey { get; private set; }

        private MessagingConfig()
        {
            EmailServiceApiKey = "EMAIL_API_KEY";
            SmsServiceApiKey = "SMS_API_KEY";
            PushNotificationServiceApiKey = "PUSH_API_KEY";
        }

        public static MessagingConfig GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MessagingConfig();
                    }
                }
            }

            return _instance;
        }
    }
}
