using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopFa.Models;
using eShopFa.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eShopFa.Data.interfaces
{
    public interface IProductRepository
    {
        public List<ProductViewModel> GetAllProducts();
        public DetailViewModel GetProductById(int ProductId);
        public Category GetCategoryByProductId(int productId);
        public bool IsExistProductById(int productId);
        public List<Category> GetAllCategories();
        public List<ProductViewModel> GetCategoryProducts(int CateId);
        public List<Product> GetProductsByCategoryId(int CateId);
    }

    public class ProductRepository : IProductRepository
    {
        private ShopContext _context;

        public ProductRepository(ShopContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public List<ProductViewModel> GetAllProducts()
        {
            return _context.BestPrices.Include(s => s.Product).Select(p => new ProductViewModel()
            {
                ProductName = p.Product.ProductName,
                ProductId = p.ProductId,
                ProductCategory = p.Product.Category.ToString(),
                Price = p.CheapestPrice,
                ImageName = p.Product.Id.ToString(),
                IsExist = (p.Quantity > 0) ? true : false
            }).ToList();

        }

        public Category GetCategoryByProductId(int productId)
        {
            return _context.Products.Where(p => p.Id == productId).Select(ca => ca.Category).SingleOrDefault();
        }

        public List<ProductViewModel> GetCategoryProducts(int CateId)
        {

            if (_context.Categories.SingleOrDefault(c => c.CategoryId == CateId) == null)
            {
                return null;
            }
            else
            {
                return _context.BestPrices.Where(b => b.CategoryId == CateId).Select(p => new ProductViewModel()
                {
                    ProductName = p.Product.ProductName,
                    ProductId = p.ProductId,
                    ProductCategory = p.Product.Category.ToString(),
                    Price = p.CheapestPrice,
                    ImageName = p.Product.Id.ToString(),
                    IsExist = (p.Quantity > 0) ? true : false
                }).ToList();
            }
        }

        public DetailViewModel GetProductById(int ProductId)
        {
            Product product = _context.Products.SingleOrDefault(p => p.Id == ProductId);
            Category category = this.GetCategoryByProductId(ProductId);
            BestPrice bestPrice = _context.BestPrices.SingleOrDefault(b => b.ProductId == ProductId);
            List<SellerProductPrice> sellerProductPrices = _context.SellerProductPrices.Where(s => s.ProductId == ProductId).ToList();
            DetailViewModel dvm = new DetailViewModel()
            {
                Category = category,
                Product = product,
                BestPrice = bestPrice,
                SellerProductPrice = sellerProductPrices
            };
            return dvm;
        }

        public List<Product> GetProductsByCategoryId(int CateId)
        {
            return _context.Categories.SingleOrDefault(c => c.CategoryId == CateId).Products.ToList();
        }

        public bool IsExistProductById(int productId)
        {
            return _context.Products.Any(p => p.Id == productId);
        }
    }


}
