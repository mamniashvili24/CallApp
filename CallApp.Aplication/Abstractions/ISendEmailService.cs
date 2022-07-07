﻿using CallApp.Domain.Respons.Models.Impementation;

namespace CallApp.Aplication.Abstractions
{
    public interface ISendEmailService
    {
        Task<bool> SendEmailAsync(EmailModel email);
    }
}