
namespace GC_Deliverable19_Lab20_CoffeeShop_Init.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Item
    {
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string productDesc;
        public string ProductDesc
        {
            get { return productDesc; }
            set { productDesc = value; }
        }

        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string imgName;
        public string ImgName
        {
            get { return imgName; }
            set { imgName = value; }
        }

        public Item () : this ("", "", 0, 0, "")
        {

        }

        public Item (string productName, string productDesc, int qty, double price, string imgName)
        {
            ProductName = productName;
            ProductDesc = productDesc;
            Qty = qty;
            Price = price;
            ImgName = imgName;
        }
    }
}