using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Project.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace project.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            //lay bien session la wishlist
            string _wishlist = HttpContext.Session.GetString("wishlist");
            List<int> _ListWishList = new List<int>();
            if (!String.IsNullOrEmpty(_wishlist))
            {
                _ListWishList = JsonConvert.DeserializeObject<List<int>>(_wishlist);
            }
            //kiem tra xem session wishlist da ton tai chua neu chuwa thi khoi tao no

            return View("Index", _ListWishList);
        }
        public IActionResult Create(int? id)
        {
            int _id = id ?? 0;
            string _wishlist = HttpContext.Session.GetString("wishlist");
            if (!String.IsNullOrEmpty(_wishlist))
            {
                List<int> _ListWishList = JsonConvert.DeserializeObject<List<int>>(_wishlist);
                bool flat = false;
                foreach (int item in _ListWishList)
                {
                    if (item == _id)
                    {
                        flat = true;
                    }
                }
                if (flat == false)
                {
                    _ListWishList.Add(_id);
                    string str_wishlist = JsonConvert.SerializeObject(_ListWishList);
                    HttpContext.Session.SetString("wishlist", str_wishlist);
                }
            }
            else
            {
                List<int> _ListWishList = new List<int>();
                _ListWishList.Add(_id);
                string str_wishlist = JsonConvert.SerializeObject(_ListWishList);
                HttpContext.Session.SetString("wishlist", str_wishlist);
            }
            return Redirect("/WishList/Index");
        }
        public IActionResult Remove(int? id)
        {
            int _id = id ?? 0;
            string _wishlist = HttpContext.Session.GetString("wishlist");
            if (!String.IsNullOrEmpty(_wishlist))
            {
                List<int> _ListWishList = JsonConvert.DeserializeObject<List<int>>(_wishlist);
                _ListWishList.Remove(_id);
                string str_wishlist = JsonConvert.SerializeObject(_ListWishList);
                HttpContext.Session.SetString("wishlist", str_wishlist);
            }
            return Redirect("/WishList/Index");
        }
    }
}
