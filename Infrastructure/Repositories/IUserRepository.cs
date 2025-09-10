using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetUserWithRoleAsync(int userId);
        Task<IEnumerable<User>> GetUsersByOrganizationAsync(int orgId);
    }
}
