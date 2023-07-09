using System;
using System.Collections.Generic;

#nullable disable

namespace AdvancedEShop.Models.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPhoto { get; set; }
        public int CategoryOder { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
