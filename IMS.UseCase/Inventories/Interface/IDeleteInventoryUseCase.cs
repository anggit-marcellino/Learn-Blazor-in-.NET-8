namespace IMS.UseCase.Inventories.Interface
{
    public interface IDeleteInventoryUseCase
    {
        Task ExecuteAsync(int inventoryId);
    }
}