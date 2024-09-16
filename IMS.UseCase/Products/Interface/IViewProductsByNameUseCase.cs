using IMS.CoreBusinsess;

namespace IMS.UseCase.Products.Interface
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteAsync(string name = "");
    }
}