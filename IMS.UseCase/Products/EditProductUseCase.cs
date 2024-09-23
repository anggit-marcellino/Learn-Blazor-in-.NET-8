using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products.Interface;

namespace IMS.UseCase.Products
{
    public class EditProductUseCase : IEditProductUseCase
	{
		private readonly IProductRepository productRepository;

		public EditProductUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}
		public async Task ExecuteAsync(Product product)
		{
			await this.productRepository.UpdateProductAsync(product);
		}
	}
}
