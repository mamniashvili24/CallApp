using CallApp.Domain.Respons.Models.Impementation;

namespace CallApp.Aplication.Abstractions
{
    public interface ISendMessageService
    {
        Task<bool> SendMessageAsync(MessageModel message);
    }
}