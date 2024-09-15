using IMS.CoreBusinsess;

namespace IMS.UseCase.Inventories.Interface
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}