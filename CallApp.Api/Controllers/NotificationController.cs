using AutoMapper;
using CallApp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using CallApp.Aplication.Abstractions;
using CallApp.Domain.Respons.Data.Implementation;
using CallApp.Domain.Respons.Models.Impementation;

namespace CallApp.Api.Controllers
{
    public class NotificationController : BaseController
    {
        private readonly ISendEmailService _sendEmailService;
        private readonly IMapper _mapper;

        public NotificationController(ISendEmailService sendEmailService, IMapper mapper)
        {
            _sendEmailService = sendEmailService;
            _mapper = mapper;
        }
        public async Task<IActionResult> SendEmail(NotificationModel model)
        {
            var email = _mapper.Map<NotificationModel, EmailModel>(model);
            var result = await _sendEmailService.SendNotificationAsync(email);
            return Response(new DataResponse<bool>
            {
                Data = result
            });
        }
    }
}