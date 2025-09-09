using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public char Gender { get; set; }
        public DateTime DOB { get; set; }
        public string PasswordHash { get; set; }   // encrypted
        public bool IsAccountLocked { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public int OrganizationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
