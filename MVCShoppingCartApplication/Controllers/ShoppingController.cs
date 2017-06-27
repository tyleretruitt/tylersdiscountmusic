using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCShoppingData;

namespace MVCShoppingCartApplication.Controllers
{
    public class ShoppingController : Controller
    {
        private MVCShoppingCartEntities db = new MVCShoppingCartEntities();

        public ActionResult Index()
        {
            return View();
        }
        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
        }

        private int RemoveItem(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i--)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
        }


        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            //cart.RemoveAt(index);

            
            if (cart[index].Quantity > 1)
            {
                cart[index].Quantity--;
            }
            else
            {
                cart.RemoveAt(index);
            }
            


            Session["cart"] = cart;
            return View("Cart");
        }
       

        public ActionResult OrderNow(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.MVCProducts.Find(id),1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(db.MVCProducts.Find(id), 1));
                else
                    cart[index].Quantity++;
                //cart.Add(new Item(db.MVCProducts.Find(id), 1));
                Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult StaticCart()
        {
            if (Session["cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("StaticCart");
            }
            
        }
    }
}