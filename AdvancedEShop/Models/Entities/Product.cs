using System;
using System.Collections.Generic;

#nullable disable

namespace AdvancedEShop.Models.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductDiscount { get; set; }
        public string ProductPhoto { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public bool IsTrandy { get; set; }
        public bool IsArrived { get; set; }

        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
    }
}
