using System;
using System.Collections.Generic;

namespace nampetTest.Models
{
    public partial class Customer
    {
        public string CustId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public short? CustType { get; set; }
        public string InitialCode { get; set; }
    }
}
