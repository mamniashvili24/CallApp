using AutoMapper;
using CallApp.Infrastruction.Entity;
using CallApp.Domain.Respons.Models.Abstraction;

namespace CallApp.Aplication.MappingProfiel
{
    public class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<Person, IBaseInfoModel>();
            CreateMap<IBaseInfoModel, Person>();
        }
    }
}