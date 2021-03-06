using AutoMapper;
using CallApp.Aplication.Abstractions;
using CallApp.Infrastruction.Entity.Database;
using CallApp.Domain.Respons.Data.Abstraction;
using CallApp.Domain.Respons.Models.Abstraction;
using CallApp.Domain.Respons.Data.Implementation;
using CallApp.Domain.Respons.Models.Impementation;
using CallApp.Infrastruction.Repository.Abstraction;

namespace CallApp.Aplication.Implemetation
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
        public IDataResponse<IBaseInfoModel> GetBaseInfo(string phoneNumber)
        {
            try
            {
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    return new DataResponse<IBaseInfoModel>()
                    {
                        IsError = true,
                        Message = "Invalid phone number"
                    };
                }
                var person = _clientRepository.GetBaseInfoByPhoneNumber(phoneNumber);
                var result = _mapper.Map<Person, BaseInfoModel>(person);

                return new DataResponse<IBaseInfoModel>()
                {
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new DataResponse<IBaseInfoModel>()
                {
                    IsError = true,
                    Message = ex.Message
                };
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return true;
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 9 || phoneNumber.Length != 12)
            {
                return false;
            }

            if (phoneNumber[0] != '5' || phoneNumber[0] != '9')
            {
                return false;
            }

            return true;
        }
    }
}