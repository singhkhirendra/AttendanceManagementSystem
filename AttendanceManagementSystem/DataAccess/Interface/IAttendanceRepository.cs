using AttendanceManagementSystem.DataAccess.Extensions;

namespace AttendanceManagementSystem.DataAccess.Interface
{
    public interface IAttendanceRepository
    {
        Task<Attendance> GetTodayAttendanceByUserIdAsync(int userId, DateTime dateTime);
        Task<IEnumerable<Attendance>> GetAttendanceByUserIdAsync(int userId);
    }
}
