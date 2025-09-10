﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class UserCreateDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public char Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Password { get; set; } = null!;
        public bool IsAccountLock { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public int OrganizationId { get; set; }
        public int CreatedBy { get; set; }
    }
}
