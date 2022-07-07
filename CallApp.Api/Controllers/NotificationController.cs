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
        private readonly ISendMessageService _sendSendMessageService;
        private readonly ISendEmailService _sendEmailService;
        private readonly IMapper _mapper;

        public NotificationController(ISendEmailService sendEmailService, ISendMessageService sendSendMessageService, IMapper mapper)
        {
            _sendSendMessageService = sendSendMessageService;
            _sendEmailService = sendEmailService;
            _mapper = mapper;
        }
        public async Task<IActionResult> SendEmail(NotificationModel model)
        {
            var email = _mapper.Map<NotificationModel, EmailModel>(model);
            var result = await _sendEmailService.SendEmailAsync(email);
            return Response(new DataResponse<bool>
            {
                Data = result
            });
        }
        public async Task<IActionResult> SentMessage(Model.MessageModel model)
        {
            var message = _mapper.Map<Model.MessageModel, Domain.Respons.Models.Impementation.MessageModel>(model);
            var result = await _sendSendMessageService.SendMessageAsync(message);
            return Response(new DataResponse<bool>
            {
                Data = result
            });
        }
    }
}