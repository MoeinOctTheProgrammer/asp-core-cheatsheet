using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class Category
    {
        public Category()
        {

        }

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(64)]
        public string CategoryName { get; set; }
        [Required]
        [MaxLength(800)]
        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }
        public List<BestPrice> BestPrices { get; set; }
    }
}
