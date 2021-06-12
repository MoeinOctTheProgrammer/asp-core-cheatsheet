using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public float Price { get; set; }
        public string ImageName { get; set; }
        public bool IsExist { get; set; }   
    }
}
