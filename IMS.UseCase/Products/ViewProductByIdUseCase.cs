using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;
using IMS.UseCase.Products.Interface;

namespace IMS.UseCase.Products
{
    public class ViewProductByIdUseCase : IViewProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> ExecuteAsync(int productId)
        {
            return await productRepository.GetProductByIdAsync(productId);
        }
    }
}
