using System;
using System.Collections.Generic;

namespace nampetTest.Models
{
    public partial class Title
    {
        public Title()
        {
            Customers = new HashSet<Customer>();
        }
        public string InitialCode { get; set; }
        public string InitialName { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
