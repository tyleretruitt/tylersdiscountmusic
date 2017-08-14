using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCShoppingData;


namespace MVCShoppingCartApplication.Controllers
{
    //This is a class to define an Item for the shopping cart
    public class Item
    {
        //Field : Private read only Access to the database
        private MVCProduct product = new MVCProduct();
        private int quantity;
        //Properties
        public MVCProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        //Default CTOR
        public Item(){ }
        //Method
        public Item(MVCProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}