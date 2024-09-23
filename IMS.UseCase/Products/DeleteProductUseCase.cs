using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products.Interface;

namespace IMS.UseCase.Products
{
    public class DeleteProductUseCase : IDeleteProductUseCase
	{
		private readonly IProductRepository productRepository;

		public DeleteProductUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}
		public async Task ExecuteAsync(int prodcuctId)
		{
			await this.productRepository.DeleteProductByIdAsync(prodcuctId);
		}
	}
}
