using System.Text;
using System.Text.Json;
using CallApp.Aplication.Abstractions;
using CallApp.Domain.Respons.Models.Impementation;

namespace CallApp.Aplication.Implemetation
{
    public class SendMessageService : ISendMessageService
    {
        public async Task<bool> SendMessageAsync(MessageModel message)
        {
            var url = "https://sms-api.wifisher.com/api/v2/send";
            var messageInJson = JsonSerializer.Serialize(message);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("api-key", "{YOUR_API_KEY}");
                var content = new StringContent(
                        messageInJson,
                        Encoding.UTF8, "application/json");

                var respons = await client.PostAsync(url, content);
                //respons.Content
                return respons.IsSuccessStatusCode;
            }
        }
    }
}
