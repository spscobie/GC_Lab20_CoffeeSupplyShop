using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
            private set { productId = value; }
        }

        private string productName;
        [Required(ErrorMessage = "Product Name is required!")]
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string productDesc;
        [Required(ErrorMessage = "Product Description is required!")]
        public string ProductDesc
        {
            get { return productDesc; }
            set { productDesc = value; }
        }

        private int qty;
        [Range(0, 100_000, ErrorMessage = "Quantity must be positive and not greater than 100,000!")]
        [Required(ErrorMessage = "You must enter in a quantity!")]
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private double price;
        [Range(0.00, 20_000.00, ErrorMessage = "Price must be positive, but no greater than $20,000!")]
        [Required(ErrorMessage = "Product must have a price!")]
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