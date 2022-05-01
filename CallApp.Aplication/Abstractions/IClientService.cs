using CallApp.Domain.Respons.Data.Abstraction;
using CallApp.Domain.Respons.Models.Abstraction;

namespace CallApp.Aplication.Abstractions
{
    public interface IClientService
    {
        IDataResponse<IBaseInfoModel> GetBaseInfo(string phoneNumber);
    }
}