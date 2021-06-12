using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShopFa.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(64)]
        public string Password { get; set; }
        [MaxLength(900)]
        public string Address { get; set; }
        [MaxLength(6)]
        public int Zipcode { get; set; }
        public DateTime RegisterDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        public int CodeMelli { get; set; }
    }
}
