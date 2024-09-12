using IMS.CoreBusinsess;
using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;

namespace IMS.UseCase.Inventories
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoryByNameAsync(name);
        }
    }
}
