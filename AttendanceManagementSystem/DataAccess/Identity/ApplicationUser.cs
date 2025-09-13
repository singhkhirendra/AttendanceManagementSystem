using Microsoft.AspNetCore.Identity;

namespace AttendanceManagementSystem.DataAccess.Identity
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom fields if needed

        public string? FullName { get; set; }
    }
}
