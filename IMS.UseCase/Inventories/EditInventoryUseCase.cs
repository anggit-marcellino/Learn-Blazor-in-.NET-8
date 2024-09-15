using IMS.CoreBusinsess;
using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;

namespace IMS.UseCase.Inventories
{
    public class EditInventoryUseCase : IEditInventoryUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public EditInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;

		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			await this.inventoryRepository.UpdateInventoryAsync(inventory);
		}
	}
}
