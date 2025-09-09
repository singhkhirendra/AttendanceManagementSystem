using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateTime EstablishmentDate { get; set; }
        public string Location { get; set; } 
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
