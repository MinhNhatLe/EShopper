﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedEShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedEShop.Components
{
    public class Navbar:ViewComponent
    {
        private readonly AdvancedEshopContext _context;

        public Navbar(AdvancedEshopContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            // đẩy dữ liệu vào
            return View(_context.Categories.ToList());
        }
    }
}
