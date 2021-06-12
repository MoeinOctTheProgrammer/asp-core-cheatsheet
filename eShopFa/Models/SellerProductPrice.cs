using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class SellerProductPrice
    {
        public SellerProductPrice()
        {

        }

        public int ProductId { get; set; }
        public int SellerId { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int QuantityInStock { get; set; }

        //Navigatin
        public Product Product { get; set; }
        public Seller Seller { get; set; }
    }
}
