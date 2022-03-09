using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.QueryObjects;

namespace ServiceLayer.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly EshopContext _context;

        public ProjectService(EshopContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets all Products
        /// </summary>
        /// <returns></returns>
        public IQueryable<Product> GetProducts()
        {
            return _context.Products.AsNoTracking().Include(i => i.Images).Include(c => c.Category).Include(m => m.Manufacturer);
        }

        public IQueryable<Product> SortFilterPage(SortFilterPageOptions options)
        {
            var ProductQuery = _context.Products
                .AsNoTracking()
                .Include(i => i.Images)
                .OrderProductsBy(options.OrderByOptions)
                .FilterProductsBy(options.FilterBy, options.FilterValue);

            options.SetupRestOfProducts(ProductQuery);
            return ProductQuery.Page(options.PageNum - 1, options.PageSize);
        }

        /// <summary>
        /// Gets all Categories
        /// </summary>
        /// <returns></returns>
        public IQueryable<Category> GetCategories()
        {
            return _context.Categorys;
        }

        /// <summary>
        /// Gets all Manufacturers
        /// </summary>
        /// <returns></returns>
        public IQueryable<Manufacturer> GetManufacturers()
        {
            return _context.Manufacturers;
        }

        /// <summary>
        /// Gets Product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IQueryable<Product> GetProduktById(int productId)
        {
            return _context.Products.AsNoTracking().Include(p => p.Images).Include(c => c.Category).Include(m => m.Manufacturer).Where(p => p.ProductId == productId);
        }

        /// <summary>
        /// Create a new Product
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns></returns>
        public async Task<Product> CreateProduct(Product newProduct)
        {
            Product product = new Product { Name = newProduct.Name, Price = newProduct.Price, CategoryId = newProduct.CategoryId, ManufacturerId = newProduct.ManufacturerId };
            await _context.Products.AddAsync(product);
            _context.SaveChanges();
            return newProduct;
        }

        /// <summary>
        /// Updates a Product
        /// </summary>
        /// <param name="updatedProduct"></param>
        /// <returns></returns>
        public async Task<Product> UpdateProduct(Product updatedProduct)
        {
            Product product = new Product { ProductId = updatedProduct.ProductId, Name = updatedProduct.Name, Price = updatedProduct.Price, CategoryId = updatedProduct.CategoryId, ManufacturerId = updatedProduct.ManufacturerId };
            _context.Products.Update(product);

            await _context.SaveChangesAsync();
            return updatedProduct;
        }

        /// <summary>
        /// Deletes a Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task<Product> DeleteProduct(int productId)
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
