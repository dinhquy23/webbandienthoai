using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Project.Models;
using Microsoft.AspNetCore.Http;
using X.PagedList;
using BC = BCrypt.Net.BCrypt;
using Project.Areas.Admin.Attributes;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [CheckLogin]
    public class UsersController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPage = 4;
            List<RecordUsers> listUsers = db.Users.OrderByDescending(item => item.ID).ToList();
            return View("Index",listUsers.ToPagedList(_CurrentPage,_RecordPage));
        }
        public IActionResult Update(int? id)
        {
            int _id = id ?? 0;
            RecordUsers record = db.Users.Where(item => item.ID == _id).FirstOrDefault();
            return View("Update", record);
        }
        [HttpPost]
        public IActionResult Update(IFormCollection fc,int? id)
        {
            int _id = id ?? 0;
            string _Name = fc["name"].ToString().Trim();

            string _Password = Request.Form["password"].ToString().Trim();
            RecordUsers record = db.Users.Where(item => item.ID == _id).FirstOrDefault();
            record.Name = _Name;
            if (!String.IsNullOrEmpty(_Password))
            {
                _Password = BC.HashPassword(_Password);
                record.Password = _Password;
            }
            db.SaveChanges();
            return Redirect("/Admin/Users");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection fc)
        {
            string _Name = fc["name"].ToString().Trim();
            string _Email = fc["email"].ToString().Trim();
            string _Password = Request.Form["password"].ToString().Trim();
            RecordUsers record = new RecordUsers();
            record.Name = _Name;
            record.Email = _Email;
            _Password = BC.HashPassword(_Password);
            record.Password = _Password;
            db.Users.Add(record);
            db.SaveChanges();
            return Redirect("/Admin/Users");
        }
        public IActionResult Delete(int? id)
        {
            int _id = id ?? 0;
            RecordUsers record = db.Users.Where(item => item.ID == _id).FirstOrDefault();
            db.Users.Remove(record);
            db.SaveChanges();
            return Redirect("/Admin/Users");
        }
    }
}
