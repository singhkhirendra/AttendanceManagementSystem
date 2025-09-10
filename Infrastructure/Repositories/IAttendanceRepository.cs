using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IAttendanceRepository : IGenericRepository<Attendance> 
    {
        Task<IEnumerable<Attendance>> GetMonthlyAttendanceAsync(int userId, int month, int year);
        Task<Attendance?> GetTodayAttendanceAsync(int userId, string type);
    }
}
