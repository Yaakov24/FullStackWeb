namespace FullStackWeb.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
