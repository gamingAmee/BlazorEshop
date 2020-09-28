using DataLayer.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.ProjectService
{
    public interface IProjectService
    {
        Task<Product> CreateProduct(Product newProduct);
        Task<Product> DeleteProduct(int productId);
        IQueryable<Category> GetCategories();
        IQueryable<Manufacturer> GetManufacturers();
        IQueryable<Product> GetProducts();
        IQueryable<Product> GetProduktById(int productId);
        Task<Product> UpdateProduct(Product updatedProduct);
        IQueryable<Product> SortFilterPage(SortFilterPageOptions options);
    }
}