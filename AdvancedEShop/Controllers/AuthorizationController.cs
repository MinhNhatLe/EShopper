using AdvancedEShop.Models;
using AdvancedEShop.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

                users.Email = Request.Cookies["Email"];
                users.Password = Request.Cookies["Password"];

                User users1 = _context.Users.Where(s => s.Email == users.Email && s.Password == users.Password).FirstOrDefault();
                if (users1 != null)
                {
                    if (users1.IsAdmin == true)
                    {
                        var admin = users1.IdUser;
                        HttpContext.Session.SetString("Admin", admin.ToString());
                    }
                    else
                    {
                        var user = users1.IdUser;
                        HttpContext.Session.SetString("User", user.ToString());
                    }
                    HttpContext.Session.SetString("Name", users1.Name.ToString());
                    return RedirectToAction("Index", "Home");
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
        public ActionResult SignIn(User userz, Remember remember)
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
                    var admin = users1.IdUser;
                    HttpContext.Session.SetString("Admin", admin.ToString());
                }
                else
                {
                    var user = users1.IdUser;
                    HttpContext.Session.SetString("User", user.ToString());
                }
                HttpContext.Session.SetString("Name", users1.Name.ToString());

                // cookie còn bị lỗi
                if (remember.RememberMe)
                {
                    Response.Cookies.Append("Email", userz.Email, new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(1),
                        Secure = true,
                        HttpOnly = true
                    });

                    Response.Cookies.Append("Password", userz.Password, new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(1),
                        Secure = true,
                        HttpOnly = true
                    });
                }

                return RedirectToAction("Index", "Home");
            }
        }


        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User userz)
        {
            try
            {
                User users2 = _context.Users.FirstOrDefault(s => s.Email == userz.Email);
                if (users2 == null)
                {
                    if (userz.Password != null)
                    {
                        User userz1 = new User();
                        userz1.Name = userz.Name;
                        userz1.Password = userz.Password;
                        userz1.IsAdmin = false;
                        userz1.Email = userz.Email;
                        userz1.Avatar = null;
                        _context.Users.Add(userz1);
                        _context.SaveChanges();


                        MailAddress fromGMail = new MailAddress("lmnnhat.work@gmail.com", "E-Shopper - CEO Lê Minh Nhật");
                        MailAddress toGMail = new MailAddress(userz.Email, "Me");
                        MailMessage Message = new MailMessage()
                        {
                            From = fromGMail,
                            Subject = "Create account successful",
                            Body = "Dear " + userz.Name.ToString() + ",\n" + "You have successfully registered\n" + "Now you can learn vocabulary, read stories and listen to stories as you please, take tests to improve your intelligence. In addition, there are other extremely cool and interesting functions.\n" + "Wish you have a meaningful lesson,\n" + "English For Kids - CEO Lê Minh Nhật",
                            Priority = MailPriority.High,
                            IsBodyHtml = false
                        };
                        Message.To.Add(toGMail);
                        SmtpClient smtp = new SmtpClient()
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential()
                            {
                                UserName = "lmnhat.work@gmail.com",
                                Password = "drhvuzjzhkoizsch"
                            }
                        };
                        smtp.Send(Message);
                        return RedirectToAction("SignIn", "Authorization");
                    }
                    else
                    {
                        ViewData["WrongPassword"] = " Please enter the your password ";
                    }
                }
                else
                {
                    ViewData["UserExisted"] = " Gmail existed ";
                }
                return this.SignUp();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear(); // Xóa tất cả dữ liệu trong Session

            // Xóa cookie "Email"
            if (Request.Cookies["Email"] != null)
            {
                Response.Cookies.Delete("Email");
            }

            // Xóa cookie "Password"
            if (Request.Cookies["Password"] != null)
            {
                Response.Cookies.Delete("Password");
            }

            return RedirectToAction("SignIn", "Authorization");
        }
    }
}
