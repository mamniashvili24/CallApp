using CallApp.Infrastruction.Entity;

namespace CallApp.Infrastruction.Repository.Abstraction
{
    public interface IClientRepository
    {
        Person GetBaseInfoByPhoneNumber(string phoneNumber);
    }
}