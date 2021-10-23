using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
//muon su dung thu vien jSon thi phai them dong duoi
using Newtonsoft.Json;
using Project.Models;

namespace Project.Models
{
    public class Cart
    {
        protected static readonly MyDbContext db = new MyDbContext();
        //------        
        public static T GetObjectFromJson<T>(ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
        //------
        //lay gio hang dang ton tai
        public static List<RecordCart> GetCart(ISession session)
        {
            //JsonConvert.DeserializeObject<T>("cart")
            List<RecordCart> cart = Cart.GetObjectFromJson<List<RecordCart>>(session, "cart");
            return cart;
        }
        //add item to cart
        public static void CartAdd(ISession session, int id)
        {
            if (Cart.GetObjectFromJson<List<RecordCart>>(session, "cart") == null)
            {
                List<RecordCart> cart = new List<RecordCart>();
                Products item = db.Products.Where(tbl => tbl.ID == id).FirstOrDefault();
                cart.Add(new RecordCart { RecordProduct = item, Quantity = 1 });
                session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
            else
            {
                List<RecordCart> cart = Cart.GetObjectFromJson<List<RecordCart>>(session, "cart");

                int index = Cart.isExist(session, id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    Products item = db.Products.Where(tbl => tbl.ID == id).FirstOrDefault();
                    cart.Add(new RecordCart { RecordProduct = item, Quantity = 1 });
                }
                session.SetString("cart", JsonConvert.SerializeObject(cart));
            }
        }
        //remove item in cart
        public static void CartRemove(ISession session, int id)
        {
            List<RecordCart> cart = Cart.GetObjectFromJson<List<RecordCart>>(session, "cart");
            int index = isExist(session, id);
            cart.RemoveAt(index);
            session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        //remove all item in cart
        public static void CartDestroy(ISession session)
        {
            List<RecordCart> cart = new List<RecordCart>();
            session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        public static void CartUpdate(ISession session, int id, int quantity)
        {
            List<RecordCart> cart = Cart.GetObjectFromJson<List<RecordCart>>(session, "cart");
            //---
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].RecordProduct.ID == id)
                {
                    cart[i].Quantity = quantity;
                }
            }
            //---
            session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        private static int isExist(ISession session, int id)
        {
            List<RecordCart> cart = Cart.GetObjectFromJson<List<RecordCart>>(session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].RecordProduct.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
