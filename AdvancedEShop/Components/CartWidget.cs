using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedEShop.Infrastructure;
using AdvancedEShop.Models;
using AdvancedEShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedEShop.Components
{
    public class CartWidget : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            // đẩy dữ liệu vào
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
