using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCShoppingData;


namespace MVCShoppingCartApplication.Controllers
{
    public class Item
    {
        private MVCProduct product = new MVCProduct();

        public MVCProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item(){ }

        public Item(MVCProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}