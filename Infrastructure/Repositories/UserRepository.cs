using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public Task<IEnumerable<User>> GetAllWithIncludesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserWithRoleAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
