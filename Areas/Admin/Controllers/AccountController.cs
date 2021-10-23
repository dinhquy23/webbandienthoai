using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using BC = BCrypt.Net.BCrypt;
using Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(IFormCollection fc)
        {
            string _email = fc["email"].ToString().Trim();
            string _password = fc["password"].ToString().Trim();
            RecordUsers record = db.Users.Where(item => item.Email == _email).FirstOrDefault();
            if (record != null)
            {
                if (BC.Verify(_password, record.Password) == true)
                {
                    HttpContext.Session.SetString("email", _email);
                    return Redirect("/Admin/Home");
                }
            }
            return Redirect("/Admin/Account/Login?notify=invalid");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            //huy bien session email
            HttpContext.Session.Remove("email");
            return Redirect("/Admin/Account/Login");
        }
    }
}
