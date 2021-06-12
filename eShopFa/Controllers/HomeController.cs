using eShopFa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eShopFa.Data.interfaces;
using eShopFa.Models.ViewModels;

namespace eShopFa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger,IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View(_productRepository.GetAllProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            if (_productRepository.IsExistProductById(id))
            {
                return View(_productRepository.GetProductById(id));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Categories()
        {
            return View(_productRepository.GetAllCategories());
        }

        public IActionResult Category(int CategoryId)
        {
            List<ProductViewModel> products = _productRepository.GetCategoryProducts(CategoryId);
            if(products == null)
            {
                return NotFound();
            }
            else
            {
                return View(products);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
