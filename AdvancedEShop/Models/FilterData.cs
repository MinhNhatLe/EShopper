using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEShop.Models
{
    public class FilterData
    {
        public List<string> PriceRanges { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }

    }
}
