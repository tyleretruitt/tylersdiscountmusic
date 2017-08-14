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
        //Field : Private read only access to the database
        private MVCShoppingCartEntities db = new MVCShoppingCartEntities();
        //Commented out the index view because it is not needed
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //class to determine if the item exists while the cart is in session
        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
        }
        
        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            
            //decreases Quatity by 1 if the delete button is selected
            if (cart[index].Quantity > 1)
            {
                cart[index].Quantity--;
            }
            //if there is only 1 item in the cart of that specific product then remove the entry
            else
            {
                cart.RemoveAt(index);
            }
            //restore session after delete is selected
            Session["cart"] = cart;
            //return new view after delete is selected
            return View("Cart");
        }
        //Action to Order a new item, passes in the Product ID as an argument
        public ActionResult OrderNow(int id)
        {
            //if the cart isnt in session then add the item
            if (Session["cart"] == null)
            {
                //establish a new List<Item>
                List<Item> cart = new List<Item>();
                //add one new item to the list based on the Product ID
                cart.Add(new Item(db.MVCProducts.Find(id),1));
                //restore session
                Session["cart"] = cart;
            }
            //if the cart is already in session then add the item
            else
            {
                //bring up the List<Item> that is already currently in session
                List<Item> cart = (List<Item>)Session["cart"];
                //brings all existing indexes
                int index = isExisting(id);
                //if the item isnt in the cart that add a new entry based on that items Product ID
                if (index == -1)
                    cart.Add(new Item(db.MVCProducts.Find(id), 1));
                //add another item to the current index based on Product ID
                else
                    cart[index].Quantity++;
                //restore session
                Session["cart"] = cart;
            }
            //return user to the 'Cart.cshtml' view
            return View("Cart");
        }
        //Separate View to enable the user to view the cart without having to pass a Product ID as an argument
        //Therefore the cart does not add an item with this action
        public ActionResult StaticCart()
        {
            //if there is no session and the cart is empty, then return the user the the Index View in the Home Controller
            if (Session["cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //present the StaticCart.cshtml view to the user
            else
            {
                return View("StaticCart");
            }
            
        }
    }
}