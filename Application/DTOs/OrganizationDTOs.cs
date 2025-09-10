using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class OrganizationDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Location { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
