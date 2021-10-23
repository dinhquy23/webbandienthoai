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
    public class ProductsController : Controller
    {
        //khai bao bien toan cuc de thao tac csdl 
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 20;
            //lay ban ghi trong bang Products
            List<Products> ListProducts = db.Products.OrderByDescending(item => item.ID).ToList();
            return View("Index", ListProducts.ToPagedList(_CurrentPage, _RecordPerPage));
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

            double _Price = Convert.ToDouble(fc["Price"].ToString().Trim());
            double _Discount = Convert.ToDouble(fc["Discount"].ToString().Trim());
            int _CategoryID = Convert.ToInt32(fc["CategoryID"].ToString().Trim());
            //---
            //lay ban ghi tuong ung voi id truyen vao
            Products record = new Products();
            //update ban ghi
            record.Name = _Name;
            record.Description = _Description;
            record.Content = _Content;
            record.Hot = _Hot;
            record.Price = _Price;
            record.Discount = _Discount;
            record.CategoryID = _CategoryID;
            //---
            //lay thong tin o the file co type="file"
            string _FileName = "";
            try
            {
                //lay ten file
                _FileName = Request.Form.Files[0].FileName;
            }
            catch {; }
            if (!String.IsNullOrEmpty(_FileName))
            {
                //upload anh moi
                //lay thoi gian gan vao ten file -> tranh cac file co ten trung ten voi file se upload
                var timestap = DateTime.Now.ToFileTime();
                _FileName = timestap + "_" + _FileName;
                //lay duong dan cua file
                string _Path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Products", _FileName);
                //upload file
                using (var stream = new FileStream(_Path, FileMode.Create))
                {
                    Request.Form.Files[0].CopyTo(stream);
                }
            }
            //update gia tri vao cot Photo trong csdl
            record.Photo = _FileName;

            //---
            //tham ban ghi vao csdl
            db.Products.Add(record);
            //cap nhat ban ghi
            db.SaveChanges();
            //---
            List<Tags> listTags = db.Tags.OrderByDescending(item => item.ID).ToList();
            foreach (var item in listTags)
            {
                string name = "tag_" + item.ID;
                if (!String.IsNullOrEmpty(Request.Form[name]))
                {
                    ProductsTags pt = new ProductsTags();
                    pt.ProductID = record.ID;
                    pt.TagID = item.ID;
                    db.ProductsTags.Add(pt);
                    db.SaveChanges();
                }
            }
            return Redirect("/Admin/Products");
        }
        public IActionResult Update(int? id)
        {
            int _id = id ?? 0;
            Products record = db.Products.Where(item => item.ID == _id).FirstOrDefault();

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
            double _Price = Convert.ToDouble(fc["Price"].ToString().Trim());
            double _Discount = Convert.ToDouble(fc["Discount"].ToString().Trim());
            int _CategoryID = Convert.ToInt32(fc["CategoryID"].ToString().Trim());

            var record = db.Products.Where(item => item.ID == _id).FirstOrDefault();
            record.Name = _Name;
            record.Description = _Description;
            record.Content = _Content;
            record.Hot = _Hot;
            record.Price = _Price;
            record.Discount = _Discount;
            record.CategoryID = _CategoryID;
            //lay thong tin the input cos type = file
            string _FileName = "";
            try
            {
                _FileName = Request.Form.Files[0].FileName;
            }
            catch {; }
            if (!String.IsNullOrEmpty(_FileName))
            {
                if (record.Photo != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", record.Photo)))
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", record.Photo));
                }
                var timestap = DateTime.Now.ToFileTime();
                _FileName = timestap + "_" + _FileName;
                string _Path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Products", _FileName);
                using (var stream = new FileStream(_Path, FileMode.Create))
                {
                    Request.Form.Files[0].CopyTo(stream);
                }
                record.Photo = _FileName;
            }
            //upload anh moi
            //lay thoi gian gan vao ten file tranh cac file co ten trung ten vs file se upload
            
            db.SaveChanges();
            List<Tags> listTags = db.Tags.OrderByDescending(item => item.ID).ToList();
            foreach (var item in listTags)
            {
                string name = "tag_" + item.ID;
                if (!String.IsNullOrEmpty(Request.Form[name]))
                {
                    ProductsTags pt = new ProductsTags();
                    pt.ProductID = record.ID;
                    pt.TagID = item.ID;
                    db.ProductsTags.Add(pt);
                    db.SaveChanges();
                }
            }
            return Redirect("/Admin/Products");
        }
        public IActionResult Delete(int? id)
        {
            int _id = id ?? 0;
            Products record = db.Products.Where(item => item.ID == _id).FirstOrDefault();
            db.Products.Remove(record);
            db.SaveChanges();
            return Redirect("/Admin/Products");
        }
    }
}
