using System.Text;
using System.Text.Json;
using CallApp.Aplication.Abstractions;
using CallApp.Domain.Respons.Models.Impementation;

namespace CallApp.Aplication.Implemetation
{
    public class SendEmailService : ISendEmailService
    {
        public async Task<bool> SendNotificationAsync(EmailModel email)
        {
            var url = "https://privateemail.aldagi.ge/swagger/index.html#/Email/Email_Post";
            var emailInJson = JsonSerializer.Serialize(email);
            using (var client = new HttpClient())
            {
                var content = new StringContent(
                    emailInJson,
                    Encoding.UTF8, "application/json");

                var respons = await client.PostAsync(url, content);

                return respons.IsSuccessStatusCode;
            }
        }
    }
}