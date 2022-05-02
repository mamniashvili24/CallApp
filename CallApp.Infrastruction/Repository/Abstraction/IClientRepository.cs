using CallApp.Infrastruction.Entity.Database;

namespace CallApp.Infrastruction.Repository.Abstraction
{
    public interface IClientRepository
    {
        Person GetBaseInfoByPhoneNumber(string phoneNumber);
    }
}