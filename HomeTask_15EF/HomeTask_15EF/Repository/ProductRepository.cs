using HomeTask_15EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Product.Find(productId);
            if (product != null)
            {
                _context.Product.Remove(product);
                _context.SaveChanges();
            }
        }

        public Product GetProductById(int productId)
        {
            return _context.Product.Find(productId);
        }
            
        public void UpdateProduct(Product product)
        {
            _context.Product.Update(product);
            _context.SaveChanges();
        }
    }
}
