using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;

namespace IMS.Plugins.InMemory
{
    public class ProductRepository : IProductRepository
    {
		private List<Product> products;
		public ProductRepository()
		{
			products = new List<Product>()
			{
				new Product() { ProductId = 1, ProductName = "Bike", Quantity = 10, Price = 150 },
				new Product() { ProductId = 2, ProductName = "Car", Quantity = 10, Price = 25000 },
			};
		}

		public Task AddProductAsync(Product product)
		{
			if (products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase)))
			{
				return Task.CompletedTask;
			}
			var maxId = products.Max(x => x.ProductId);
			product.ProductId = maxId + 1;

			products.Add(product);

			return Task.CompletedTask;
		}

		public Task DeleteProductByIdAsync(int inventoryId)
		{
			var productDelete = products.FirstOrDefault(x => x.ProductId == inventoryId);
			if (productDelete != null)
			{
				products.Remove(productDelete);
			}
			return Task.CompletedTask;
		}

		public async Task<Product> GetProductByIdAsync(int productId)
		{
			return await Task.FromResult(products.First(x => x.ProductId == productId));
		}

		public async Task<IEnumerable<Product>> GetProductByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return await Task.FromResult(products);
			}

			return await Task.FromResult(products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase)));
		}

		public Task UpdateProductAsync(Product product)
		{
			if (products.Any(x => x.ProductId != product.ProductId &&
				x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase)))
			{
				return Task.CompletedTask;
			}
			var productUpdate = products.FirstOrDefault(x => x.ProductId == product.ProductId);
			if (productUpdate is not null)
			{
				productUpdate.ProductName = product.ProductName;
				productUpdate.Quantity = product.Quantity;
				productUpdate.Price = product.Price;
			}

			return Task.CompletedTask;
		}
	}
}
