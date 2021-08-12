using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAssemblyProject.Client.Shared
{
    public class Cart
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityPurchased { get; set; }

        public Cart(int productId, string productName, float price, int quantity, string description, string imageUrl, int quantityPurchased)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            Description = description;
            ImageUrl = imageUrl;
            QuantityPurchased = quantityPurchased;
        }

        public Cart() { }

        public override string ToString()
        {
            string str = $"ProductId : {ProductId}; ProductName: {ProductName}; Price : {Price}; Quantity Purchased:{QuantityPurchased}; Description: {Description}";
            return str;
        }
    }
}
