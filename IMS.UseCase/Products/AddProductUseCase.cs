using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products.Interface;

namespace IMS.UseCase.Products
{
    public class AddProductUseCase : IAddProductUseCase
	{
		private readonly IProductRepository productRepository;

		public AddProductUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;

		}
		public async Task ExecuteAsync(Product product)
		{
			await this.productRepository.AddProductAsync(product);
		}
	}
}
