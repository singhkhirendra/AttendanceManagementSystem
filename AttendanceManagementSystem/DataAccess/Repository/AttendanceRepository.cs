using AttendanceManagementSystem.DataAccess.Entities.Data;
using AttendanceManagementSystem.DataAccess.Extensions;
using AttendanceManagementSystem.DataAccess.Interface;

namespace AttendanceManagementSystem.DataAccess.Repository
{
    public class AttendanceRepository : GenericRepository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(AppDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Attendance>> GetAttendanceByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Attendance> GetTodayAttendanceByUserIdAsync(int userId, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
