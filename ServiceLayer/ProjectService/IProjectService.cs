using DataLayer.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.ProjectService
{
    public interface IProjectService
    {
        Task<Product> Create(Product newProduct);
        Task<Product> Delete(int productId);
        IQueryable<Category> GetCategories();
        IQueryable<Manufacturer> GetProducenter();
        IQueryable<Product> GetProducts();
        IQueryable<Product> GetProduktById(int productId);
        Task<Product> Update(Product updatedProduct);
    }
}