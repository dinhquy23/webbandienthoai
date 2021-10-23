using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Project.Models;
using Project.Areas.Admin.Attributes;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using System.IO;


namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [CheckLogin]
    public class NewsController : Controller
    {
        //khai bao bien toan cuc de thao tac csdl 
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 20;
            //lay ban ghi trong bang News
            List<News> ListNews = db.News.OrderByDescending(item => item.ID).ToList();
            return View("Index",ListNews.ToPagedList(_CurrentPage,_RecordPerPage));
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection fc)
        {
            string _Name = fc["Name"].ToString().Trim();
            string _Description = fc["Description"].ToString().Trim();
            string _Content = fc["Content"].ToString().Trim();
            int _Hot = fc["Hot"] != "" && fc["Hot"] == "on" ? 1 : 0;
            News record = new News();
            record.Name = _Name;
            record.Description = _Description;
            record.Content = _Content;
            record.Hot = _Hot;
            string _FileName = "";
            try
            {
                //lay ten file
                _FileName = Request.Form.Files[0].FileName;
            }
            catch {; }
            if(!String.IsNullOrEmpty(_FileName))
            {
                //upload anh moi
                //lay thoi gian gan vao ten file -> tranh cac file co ten trung ten voi file se upload
                var timestap = DateTime.Now.ToFileTime();
                _FileName = timestap + "_" + _FileName;
                //lay duong dan cua file
                string _Path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/News", _FileName);
                //upload file
                using (var stream = new FileStream(_Path, FileMode.Create))
                {
                    Request.Form.Files[0].CopyTo(stream);
                }
            }
            record.Photo = _FileName;
            db.News.Add(record);
            db.SaveChanges();
            return Redirect("/Admin/News");
        }
        public IActionResult Update(int? id)
        {
            int _id = id ?? 0;
            News record = db.News.Where(item => item.ID == _id).FirstOrDefault();

            return View("Update", record);
        }
        [HttpPost]
        public IActionResult Update(IFormCollection fc, int? id)
        {
            int _id = id ?? 0;
            string _Name = fc["Name"].ToString().Trim();
            string _Description = fc["Description"].ToString().Trim();
            string _Content = fc["Content"].ToString().Trim();
            int _Hot = fc["Hot"] != "" && fc["Hot"] == "on" ? 1 : 0;
            var record = db.News.Where(item => item.ID == _id).FirstOrDefault();
            record.Name = _Name;
            record.Description = _Description;
            record.Content = _Content;
            record.Hot = _Hot;
            //lay thong tin the input cos type = file
            string _FileName = "";
            try
            {
                _FileName = Request.Form.Files[0].FileName;
            }
            catch {; }
            if (!String.IsNullOrEmpty(_FileName))
            {
                if (record.Photo != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "News", record.Photo)))
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "News", record.Photo));
                }
                //upload anh moi
                //lay thoi gian gan vao ten file tranh cac file co ten trung ten vs file se upload
                var timestap = DateTime.Now.ToFileTime();
                _FileName = timestap + "_" + _FileName;
                string _Path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/News", _FileName);
                using (var stream = new FileStream(_Path, FileMode.Create))
                {
                    Request.Form.Files[0].CopyTo(stream);
                }
                record.Photo = _FileName;
            }
           
            db.SaveChanges();
            return Redirect("/Admin/News");
        }
        public IActionResult Delete(int? id)
        {
            int _id = id ?? 0;
            News record = db.News.Where(item => item.ID == _id).FirstOrDefault();
            db.News.Remove(record);
            db.SaveChanges();
            return Redirect("/Admin/News");
        }
    }
}
