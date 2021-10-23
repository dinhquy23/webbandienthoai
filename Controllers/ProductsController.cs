using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Project.Controllers
{
    public class ProductsController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            string strOrder = "";
            if (!String.IsNullOrEmpty(Request.Query["order"]))
            {
                strOrder = Request.Query["order"];
            }
            int _RecordPerPage = 16;
            int _CurrentPage = page ?? 1;
            IEnumerable<Products> record = db.Products.OrderByDescending(item => item.ID).ToList();
            switch (strOrder)
            {
                case "nameAsc":
                    record = record.OrderBy(item => item.Name);
                    break;
                case "nameDesc":
                    record = record.OrderByDescending(item => item.Name);
                    break;
                case "priceAsc":
                    record = record.OrderBy(item => item.Price-(item.Price*item.Discount)/100);
                    break;
                case "priceDesc":
                    record = record.OrderByDescending(item => item.Price - (item.Price * item.Discount) / 100);
                    break;
            }
            return View("Index", record.ToPagedList(_CurrentPage, _RecordPerPage));
        }
        public IActionResult Category(int? id, int? page)
        {
            string strOrder = "";
            if (!String.IsNullOrEmpty(Request.Query["order"]))
            {
                strOrder = Request.Query["order"];
            }
            int _id = id ?? 0;
            ViewBag.CategoryID = _id;
            int _RecordPerPage = 12;
            int _CurrentPage = page ?? 1;
            IEnumerable<Products> _ListRecord = db.Products.OrderByDescending(item => item.ID).Where(tbl => tbl.CategoryID == _id).ToList();
            switch (strOrder)
            {
                case "nameAsc":
                    _ListRecord = _ListRecord.OrderBy(item => item.Name);
                    break;
                case "nameDesc":
                    _ListRecord = _ListRecord.OrderByDescending(item => item.Name);
                    break;
                case "priceAsc":
                    _ListRecord = _ListRecord.OrderBy(item => item.Price - (item.Price * item.Discount) / 100);
                    break;
                case "priceDesc":
                    _ListRecord = _ListRecord.OrderByDescending(item => item.Price - (item.Price * item.Discount) / 100);
                    break;
            }
            return View("Category", _ListRecord.ToPagedList(_CurrentPage, _RecordPerPage));
        }
        public IActionResult Detail(int? id)
        {
            int _id = id ?? 0;
            //lay mot ban ghi
            Products record = db.Products.Where(item => item.ID == _id).FirstOrDefault();
            //goi view, truyen du lieu ra view
            return View("Detail", record);
        }
        public IActionResult Star(int? id)
        {
            if (HttpContext.Session.GetString("customer_email") == null)
            {
                return Redirect("/Account/Login");
            }
            else
            {
                int _ProductID = id ?? 0;
                int _Star = !String.IsNullOrEmpty(Request.Query["star"]) ? Convert.ToInt32(Request.Query["star"]) : 0;
                Rating record = new Rating();
                record.ProductID = _ProductID;
                record.Star = _Star;
                db.Ratings.Add(record);
                db.SaveChanges();
                return Redirect("/Products/Detail/" + _ProductID);
            }
            
        }
    }
}
