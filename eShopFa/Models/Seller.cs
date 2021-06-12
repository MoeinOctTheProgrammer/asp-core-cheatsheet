using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class Seller
    {
        public Seller()
        {

        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string BusinessName { get; set; }
        [Required]
        [MaxLength(800)]
        public string BusinessAddress { get; set; }
        [Required]
        [MaxLength(12)]
        public string BusinessPhoneNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string SellerName { get; set; }
        [Required]
        [MaxLength(11)]
        public string SellerPhoneNumber { get; set; }


        public List<SellerProductPrice> Products { get; set; }
    }
}
