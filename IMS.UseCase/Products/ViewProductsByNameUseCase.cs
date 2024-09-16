using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products.Interface;

namespace IMS.UseCase.Products
{
	public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
	{
		private readonly IProductRepository productRepository;

		public ViewProductsByNameUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
		{
			return await productRepository.GetProductByNameAsync(name);
		}
	}
}
