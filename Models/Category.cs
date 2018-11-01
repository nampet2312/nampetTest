using System;
using System.Collections.Generic;

namespace nampetTest.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string CatId { get; set; }
        public string CatName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
