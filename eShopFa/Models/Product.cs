using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class Product
    {
        public Product()
        {

        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }


        public Category Category { get; set; }
        public List<SellerProductPrice> Sellers { get; set; }
        public BestPrice BestPrice { get; set; }
    }
}
