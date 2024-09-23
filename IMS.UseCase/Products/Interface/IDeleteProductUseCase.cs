namespace IMS.UseCase.Products.Interface
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(int prodcuctId);
    }
}