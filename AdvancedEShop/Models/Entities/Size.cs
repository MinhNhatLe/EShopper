﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AdvancedEShop.Models.Entities
{
    public partial class Size
    {
        public Size()
        {
            Products = new HashSet<Product>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public int? IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
