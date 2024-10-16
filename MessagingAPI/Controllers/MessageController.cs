using MessagingAPI.Builders;
using MessagingAPI.Configuration;
using MessagingAPI.Models;
using MessagingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessagingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpPost("send")]
        public IActionResult SendMessage([FromBody] MessageRequest request)
        {
            var config = MessagingConfig.GetInstance(); // Singleton

            var builder = new MessageBuilder()
                .SetRecipient(request.Recipient)
                .SetSubject(request.Subject)
                .SetBody(request.Body);

            var message = builder.BuildMessage(request.MessageType);
            message.SendMessage();

            switch (request.MessageType)
            {
                case "Email":
                    return Ok("Email enviado exitosamente.");
                case "SMS":
                    return Ok("Mensaje enviado exitosamente.");
                case "Push":
                    return Ok("Push enviado exitosamente.");
                default:
                    throw new ArgumentException("Tipo de mensaje no soportado.");
            }
        }
    }
}
