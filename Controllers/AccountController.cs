using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Project.Models;
//using doi tuong phan trang
using X.PagedList;
//de nhin thay file checklogin.cs trong thu muc Attributes
using Project.Areas.Admin.Attributes;
using BC = BCrypt.Net.BCrypt;
namespace Project.Controllers
{
    public class AccountController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Register()
        {
            return View("Register");
        }
        public IActionResult RegisterPost(IFormCollection fc)
        {
            string _name = fc["name"];
            string _email = fc["email"];
            string _phone = fc["phone"];
            string _address = fc["address"];
            string _password = fc["password"];
            _password = BC.HashPassword(_password);
            int checkEmail = db.Customers.Where(item => item.Email == _email).Count();
            if (checkEmail == 0)
            {
                Customers record = new Customers();
                record.Name = _name;
                record.Email = _email;
                record.Phone = _phone;
                record.Address = _address;
                record.Password = _password;
                db.Customers.Add(record);
                db.SaveChanges();
            }
            return Redirect("/Account/Login?notify=register-success");
        }
        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult LoginPost(IFormCollection fc)
        {
            string _email = fc["email"];
            string _password = fc["password"];
            Customers record = db.Customers.Where(item => item.Email == _email).FirstOrDefault();
            if (record != null && BC.Verify(_password, record.Password) == true)
            {
                HttpContext.Session.SetString("customer_email", record.Email.ToString());
                HttpContext.Session.SetString("customer_id", record.ID.ToString());
            }
            else
                return Redirect("/Account/Login?notify=invalid");
            return Redirect("/Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("customer_email");
            HttpContext.Session.Remove("customer_id");
            return Redirect("/Account/Login");
        }
        public IActionResult Orders()
        {
            int _CustomerID = Convert.ToInt32(HttpContext.Session.GetString("customer_id"));
            //lay cac don hang cua customer
            List<Orders> _ListRecord = db.Orders.Where(item => item.CustomerID == _CustomerID).OrderByDescending(tbl => tbl.ID).ToList();
            return View("Orders", _ListRecord);

        }
        public IActionResult RemoveOrders(int? id)
        {
            int orderID = id ?? 0;
            Orders record = db.Orders.Where(item => item.ID == orderID).FirstOrDefault();
            if (record != null)
            {
                record.Status = 2;
                db.SaveChanges();
            }
            return Redirect("/Account/Orders");
        }
    }
}
