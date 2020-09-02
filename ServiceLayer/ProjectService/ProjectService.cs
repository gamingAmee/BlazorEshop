using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ServiceLayer.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly EshopContext _context;

        public ProjectService(EshopContext context)
        {
            _context = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.Products.AsNoTracking().Include(i => i.Images).Include(c => c.Category).Include(m => m.Manufacturer);
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categorys;
        }

        public IQueryable<Manufacturer> GetProducenter()
        {
            return _context.Manufacturers;
        }

        public IQueryable<Product> GetProduktById(int productId)
        {
            return _context.Products.AsNoTracking().Include(p => p.Images).Include(c => c.Category).Include(m => m.Manufacturer).Where(p => p.ProductId == productId);
        }


        public async Task<Product> Create(Product newProduct)
        {
            Product product = new Product { Name = newProduct.Name, Price = newProduct.Price, CategoryId = newProduct.CategoryId, ManufacturerId = newProduct.ManufacturerId };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return newProduct;
        }

        public async Task<Product> Update(Product updatedProduct)
        {
            Product product = new Product { ProductId = updatedProduct.ProductId, Name = updatedProduct.Name, Price = updatedProduct.Price, CategoryId = updatedProduct.CategoryId, ManufacturerId = updatedProduct.ManufacturerId };
            _context.Products.Update(product);

            await _context.SaveChangesAsync();
            return updatedProduct;
        }

        public async Task<Product> Delete(int productId)
        {
            Product product = await _context.Products.Include(p => p.Images).SingleOrDefaultAsync(p => p.ProductId == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            return product;
        }
    }
}
