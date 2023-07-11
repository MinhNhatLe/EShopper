using AdvancedEShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEShop.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly AdvancedEshopContext _context;

        public AuthorizationController(AdvancedEshopContext context)
        {
            _context = context;
        }
        public ActionResult SignIn()
        {
            User users = new User();
            if (Request.Cookies["Email"] != null && Request.Cookies["Password"] != null)
            {
                User users1 = _context.Users.Where(s => s.Email == users.Email && s.Password == users.Password).FirstOrDefault();
                if (users1 != null)
                {
                    if (users1.IsAdmin == true)
                    {
                        ViewBag.Admin = users1.IdUser;
                    }
                    else
                    {
                        ViewBag.User = users1.IdUser;
                    }
                    return RedirectToAction("Index", "Users");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult SignIn(User userz)
        {
            User users1 = _context.Users.Where(s => s.Password == userz.Password && s.Email == userz.Email).FirstOrDefault();
            if (users1 == null)
            {
                ViewData["UserNotFound"] = " Please enter the correct account and password ";
                return this.SignIn();
            }
            else
            {
                if (users1.IsAdmin == true)
                {
                    ViewBag.Admin = users1.IdUser;
                }
                // Nếu không thì vào user
                else
                {
                    ViewBag.User = users1.IdUser;
                }
                return RedirectToAction("Index", "Users");
            }
        }
    }
}
