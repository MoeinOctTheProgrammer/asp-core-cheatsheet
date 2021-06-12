using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class BestPrice
    {
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        public float CheapestPrice { get; set; }
        public int Quantity { get; set; }
        
        //Navigation
        public Seller Seller { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
