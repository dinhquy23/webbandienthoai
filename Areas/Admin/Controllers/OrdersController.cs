using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Configuration;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Project.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;
using Project.Areas.Admin.Attributes;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [CheckLogin]
    public class OrdersController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index(int? page)
        {
            int _CurrentPage = page ?? 1;
            int _RecordPerPage = 20;
            List<Orders> _ListRecord = db.Orders.OrderByDescending(item => item.ID).ToList();
            return View("Index", _ListRecord.ToPagedList(_CurrentPage, _RecordPerPage));
        }
        public IActionResult Detail(int? id)
        {
            int _OrderID = id ?? 0;
            ViewBag.OrderID = id;
            List<OrdersDetail> _ListRecord = db.OrdersDetails.Where(tbl => tbl.OrderID == _OrderID).ToList();
            return View("Detail", _ListRecord);
        }
        public IActionResult Delivery(int? id)
        {
            int _OrderID = id ?? 0;
            Orders record = db.Orders.Where(tbl => tbl.ID == _OrderID).FirstOrDefault();
            if (record != null)
            {
                record.Status = 1;
                db.SaveChanges();
            }
            return Redirect("/Admin/Orders");
        }
    }
}
