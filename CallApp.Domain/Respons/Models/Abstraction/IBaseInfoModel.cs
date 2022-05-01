﻿namespace CallApp.Domain.Respons.Models.Abstraction
{
    public interface IBaseInfoModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalNumber { get; set; }
    }
}