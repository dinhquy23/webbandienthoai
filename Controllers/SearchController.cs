using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Project.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;
using Microsoft.Data.SqlClient;

namespace Project.Controllers
{
    public class SearchController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult SearchProducts(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 16;
            string key = !String.IsNullOrEmpty(Request.Query["key"]) ? Request.Query["key"] : "";
            ViewBag.key = key;
            List<Products> record = db.Products.Where(item => item.Name.Contains(key)).OrderByDescending(item => item.ID).ToList();
            return View("SearchProducts", record.ToPagedList(_CurrentPage, _RecordPerPage));
        }
        public string Ajax()
        {
            string key = !String.IsNullOrEmpty(Request.Query["key"]) ? Request.Query["key"] : "";
            List<Products> record = db.Products.Where(item => item.Name.Contains(key)).OrderByDescending(item => item.ID).ToList();
            string str = "";
            foreach (var item in record)
            {
                str = str + "<li><a href='/Products/Detail/" + item.ID + "'><img src='/Upload/Products/" + item.Photo + "'><p>" + item.Name + "</p></a></li>";
            }
            return str;
        }
        [HttpPost]
        public IActionResult SearchMix(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 16;
            int Brand =Convert.ToInt32(Request.Form["brand"].ToString().Trim());
            string Cost = Request.Form["cost"].ToString().Trim();
            List<Products> product = new List<Products>();
            if(Brand==0&&Cost==null)
            {
                ViewBag.kq = "Nhập thông tin tìm kiếm";
                return View("SearchMix", product);
            }
            else if (Brand != 0 &&Cost==null)
            {
                product = db.Products.Where(item => item.CategoryID==Brand).ToList();
            }
            else if(Brand==0 &&Cost!=null)
{
                switch (Cost)
                {
                    case "gia1":
                        product = db.Products.Where(item => (item.Price-(item.Price*item.Discount/100))<=5000000).ToList();
                        break;
                    case "gia2":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 5000000 && (item.Price - (item.Price * item.Discount / 100)) <=10000000).ToList();
                        break;
                    case "gia3":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 10000000 && (item.Price - (item.Price * item.Discount / 100)) <= 20000000).ToList();
                        break;
                    case "gia4":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 20000000 ).ToList();
                        break;
                }
            }
            else if(Brand!=0 &&Cost!=null)
            {
                switch (Cost)
                {
                    case "gia1":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) <= 5000000 && item.CategoryID==Brand).ToList();
                        break;
                    case "gia2":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 5000000 && (item.Price - (item.Price * item.Discount / 100)) <= 10000000 && item.CategoryID == Brand).ToList();
                        break;
                    case "gia3":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 10000000 && (item.Price - (item.Price * item.Discount / 100)) <= 20000000 && item.CategoryID == Brand).ToList();
                        break;
                    case "gia4":
                        product = db.Products.Where(item => (item.Price - (item.Price * item.Discount / 100)) > 20000000 && item.CategoryID == Brand).ToList();
                        break;
                }
            }
            return View("SearchMix",product.ToPagedList(_CurrentPage,_RecordPerPage));
        }
        public IActionResult SearchPrice(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 20;
            double fromPrice = !String.IsNullOrEmpty(Request.Query["fromPrice"]) ? Convert.ToDouble(Request.Query["fromPrice"]) : 0;
            double toPrice = !String.IsNullOrEmpty(Request.Query["toPrice"]) ? Convert.ToDouble(Request.Query["toPrice"]) : 0;
            ViewBag.fromPrice = fromPrice;
            ViewBag.toPrice = toPrice;
            List<Products> record = db.Products.Where(item => (item.Price - (item.Price * item.Discount) / 100) >= fromPrice && (item.Price - (item.Price * item.Discount) / 100) <= toPrice).OrderByDescending(item => item.ID).ToList();
            return View("SearchPrice", record.ToPagedList(_CurrentPage, _RecordPerPage));
        }
        public IActionResult Tags(int? id, int? page)
        {
            int _id = id ?? 0;
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 16;
            ViewBag.id = _id;
            List<ProductsTags> listTag = db.ProductsTags.Where(item => item.TagID == _id).ToList();
            List<int> listIDProduct = new List<int>();
            foreach (var itemTag in listTag)
            {
                listIDProduct.Add(itemTag.ProductID);
            }
            List<Products> listRecord = db.Products.Where(item => listIDProduct.Contains(item.ID)).OrderByDescending(item => item.ID).ToList();
            return View("Tags", listRecord.ToPagedList(_CurrentPage, _RecordPerPage));
        }
    }
}
