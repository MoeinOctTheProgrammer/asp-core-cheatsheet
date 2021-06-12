using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models.ViewModels
{
    public class DetailViewModel
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public BestPrice BestPrice { get; set; }
        public List<SellerProductPrice> SellerProductPrice { get; set; }
    }
}
