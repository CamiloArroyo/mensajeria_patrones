using MessagingAPI.Services;

namespace MessagingAPI.Builders
{
    public class MessageBuilder
    {
        private string _recipient;
        private string _subject;
        private string _body;

        public MessageBuilder SetRecipient(string recipient)
        {
            _recipient = recipient;
            return this;
        }

        public MessageBuilder SetSubject(string subject)
        {
            _subject = subject;
            return this;
        }

        public MessageBuilder SetBody(string body)
        {
            _body = body;
            return this;
        }

        public IMessage BuildMessage(string messageType)
        {
            var message = MessageFactory.CreateMessage(messageType);
            return message;
        }
    }
}
