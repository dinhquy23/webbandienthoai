using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Project.Models;
//su dung bien session thi phai khai bao dong sau
using Microsoft.AspNetCore.Http;
namespace Project.Controllers
{
    public class CartController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index()
        {
            List<RecordCart> _cart = Cart.GetCart(HttpContext.Session);
            if(_cart!=null)
            {
                ViewBag._cart = _cart;
                ViewBag._total = _cart.Sum(tbl => (tbl.RecordProduct.Price - (tbl.RecordProduct.Price * tbl.RecordProduct.Discount / 100)) * tbl.Quantity);
            }
            return View();
        }
        public IActionResult Buy(int id)
        {
            //goi ham CartAdd trong class Cart de them phan tu vao gio hang
            Cart.CartAdd(HttpContext.Session, id);
            //di chuyen den url: /Cart
            return Redirect("/Cart");
        }
        public IActionResult Remove(int id)
        {
            //goi ham CartRemove trong class Cart de xoa phan tu khoi gio hang
            Cart.CartRemove(HttpContext.Session, id);
            //di chuyen den url: /Cart
            return Redirect("/Cart");
        }
        //xoa toan bo san phan pham khoi gio hang
        public IActionResult Destroy()
        {
            //goi ham CartDestroy trong class Cart de xoa tat ca cac phan tu khoi gio hang
            Cart.CartDestroy(HttpContext.Session);
            //di chuyen den url: /Cart
            return Redirect("/Cart");
        }
        //cap nhat so luong san pham trong gio hang
        public IActionResult Update()
        {
            //lay cac phan tu trong session cart
            List<RecordCart> _cart = Cart.GetCart(HttpContext.Session);
            //duyet cac phan tu trong list _cart
            foreach (var item in _cart)
            {
                //lay so luong cua cac phan tu
                int quantity = Convert.ToInt32(Request.Form["product_" + item.RecordProduct.ID]);
                //goi ham CartUpdate de update lai so luong san pham
                Cart.CartUpdate(HttpContext.Session, item.RecordProduct.ID, quantity);
            }
            //di chuyen den url: /Cart
            return Redirect("/Cart");
        }
        public IActionResult Checkout()
        {
            //kiem tra neu user chua dang nhap thi yeu cau dang nhap
            if (HttpContext.Session.GetString("customer_email") == null)
            {
                return Redirect("/Account/Login");
            }
            else
            {
                List<RecordCart> _cart = Cart.GetCart(HttpContext.Session);
                //lay customer_id cua session
                int customer_id = int.Parse(HttpContext.Session.GetString("customer_id"));
                //insert du lieu vao table Orders
                Orders _RecordOrder = new Orders();
                _RecordOrder.CustomerID = customer_id;
                _RecordOrder.Create = DateTime.Now;
                _RecordOrder.Price = _cart.Sum(tbl => tbl.RecordProduct.Price * tbl.Quantity);
                db.Orders.Add(_RecordOrder);
                db.SaveChanges();
                //lay id vua insert
                int order_id = _RecordOrder.ID;
                //duyet cac phan tu trong session, moi phan tu se add thanh 1 ban ghi trong OrdersDetail
                foreach (var item in _cart)
                {
                    OrdersDetail _RecordOrdersDetail = new OrdersDetail();
                    _RecordOrdersDetail.OrderID = order_id;
                    _RecordOrdersDetail.ProductID = item.RecordProduct.ID;
                    _RecordOrdersDetail.Price = item.RecordProduct.Price - (item.RecordProduct.Price * item.RecordProduct.Discount) / 100;
                    _RecordOrdersDetail.Quantity = item.Quantity;
                    //---
                    
                    db.OrdersDetails.Add(_RecordOrdersDetail);
                    db.SaveChanges();
                }
                //xoa tat ca cac phan tu trong gio hang
                Cart.CartDestroy(HttpContext.Session);
                return Redirect("/Cart?checout=success");
            }
        }
        public string AjaxUpdate()
        {
            int productID = !String.IsNullOrEmpty(Request.Query["productID"]) ? Convert.ToInt32(Request.Query["productID"]) : 0;
            int quantity = !String.IsNullOrEmpty(Request.Query["quantity"]) ? Convert.ToInt32(Request.Query["quantity"]) : 0;
            Cart.CartUpdate(HttpContext.Session, productID, quantity);
            List<RecordCart> _cart = Cart.GetCart(HttpContext.Session);
            if (_cart != null)
            {
                RecordCart product = _cart.Where(item => item.RecordProduct.ID == productID).FirstOrDefault();
                if (product != null)
                {
                    return string.Format("{0:#,#.}", product.Quantity * (product.RecordProduct.Price - (product.RecordProduct.Price * product.RecordProduct.Discount) / 100)) + "đ";
                }
            }
            return "0";
        }
        public string AjaxGetTotalPrice()
        {
            int productID = !String.IsNullOrEmpty(Request.Query["productID"]) ? Convert.ToInt32(Request.Query["productID"]) : 0;
            int quantity = !String.IsNullOrEmpty(Request.Query["quantity"]) ? Convert.ToInt32(Request.Query["quantity"]) : 0;
            Cart.CartUpdate(HttpContext.Session, productID, quantity);
            List<RecordCart> _cart = Cart.GetCart(HttpContext.Session);
            double totalPrice = 0;
            if(_cart!=null)
            {
                totalPrice=_cart.Sum(tbl => (tbl.RecordProduct.Price - (tbl.RecordProduct.Price * tbl.RecordProduct.Discount / 100)) * tbl.Quantity);
            }
            return string.Format("{0:#,#.}", totalPrice) + "đ";
        }
    }
}
