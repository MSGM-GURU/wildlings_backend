using System;
using System.Collections.Generic;

namespace wildlings_backend.wildlings
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonalId { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
    }
}
