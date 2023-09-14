using ecom.Models;

namespace ecom.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int id);
        void InsertProduct(Product product);
        void DeleteProduct(int product);
        void UpdateProduct(Product product);
        void Save();
    }
}
