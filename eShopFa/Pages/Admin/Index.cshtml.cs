using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eShopFa.Data;
using eShopFa.Models;

namespace eShopFa.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly eShopFa.Data.ShopContext _context;

        public IndexModel(eShopFa.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
