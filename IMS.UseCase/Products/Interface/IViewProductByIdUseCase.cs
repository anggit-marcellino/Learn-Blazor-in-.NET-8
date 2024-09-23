using IMS.CoreBusinsess;

namespace IMS.UseCase.Products.Interface
{
    public interface IViewProductByIdUseCase
    {
        Task<Product> ExecuteAsync(int productId);
    }
}