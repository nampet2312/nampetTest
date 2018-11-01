using System;
using System.Collections.Generic;

namespace nampetTest.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }
        public string UnitCode { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
