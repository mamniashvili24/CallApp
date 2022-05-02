using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CallApp.Infrastruction.Database;
using CallApp.Infrastruction.Entity.Database;
using CallApp.Infrastruction.Repository.Abstraction;

namespace CallApp.Infrastruction.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        private readonly AldagiDbContext _context;

        public ClientRepository(AldagiDbContext context)
        {
            _context = context;
        }
        public Person GetBaseInfoByPhoneNumber(string phoneNumber)
        {
            var sqlParameters = new SqlParameter { ParameterName = "@PhoneNumber", Value = phoneNumber };
            var person = _context
                .People
                .FromSqlRaw("exec GetAllPersons @PhoneNumber", sqlParameters).ToList();

            return person.FirstOrDefault();
        }
    }
}