namespace MessagingAPI.Models
{
    public class MessageRequest
    {
        public string Recipient { get; set; }
        public string? Subject { get; set; }
        public string Body { get; set; }
        public string MessageType { get; set; }
    }
}
