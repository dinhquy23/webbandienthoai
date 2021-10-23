using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
//nhin thay cac file .cs ben trong folder Models
using Project.Models;
using Microsoft.EntityFrameworkCore;
//phan trang
using X.PagedList;
//nhin thay file CheckLogin.cs trong thu muc Attributes
using Project.Areas.Admin.Attributes;
//doi tuong thao tac file
using System.IO;

namespace Project.Controllers
{
    public class NewsController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            int _RecordPerPage = 6;
            int _PageNumber = page ?? 1;
            List<News> record = db.News.OrderByDescending(item => item.ID).ToList();
            return View("Index", record.ToPagedList(_PageNumber, _RecordPerPage));
        }
        public IActionResult Detail(int? id)
        {
            int _id = id ?? 0;
            ViewBag.ID = _id;
            return View("Detail");
        }
    }
}
