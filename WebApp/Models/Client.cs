using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Client
    {
        public Guid id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string LegalAddress { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
