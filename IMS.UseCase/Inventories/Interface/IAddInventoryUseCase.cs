using IMS.CoreBusinsess;

namespace IMS.UseCase.Inventories.Interface
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}