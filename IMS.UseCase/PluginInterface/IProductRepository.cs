using IMS.CoreBusinsess;

namespace IMS.UseCase.PluginInterface
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetProductByNameAsync(string name);

		Task AddProductAsync(Product product);

		Task UpdateProductAsync(Product product);

		Task<Product> GetProductByIdAsync(int productId);

		Task DeleteProductByIdAsync(int productId);
	}
}
