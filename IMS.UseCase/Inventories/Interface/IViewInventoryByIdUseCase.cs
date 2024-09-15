using IMS.CoreBusinsess;

namespace IMS.UseCase.Inventories.Interface
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}