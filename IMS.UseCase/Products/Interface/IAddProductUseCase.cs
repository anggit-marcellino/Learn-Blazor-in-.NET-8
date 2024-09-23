using IMS.CoreBusinsess;

namespace IMS.UseCase.Products.Interface
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}