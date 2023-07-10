using AdvancedEShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEShop.Models.ViewModels
{
    public class ProductListViewModels
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
        public PagingInfo PageingInfo { get; set; } = new PagingInfo();
    }
}
