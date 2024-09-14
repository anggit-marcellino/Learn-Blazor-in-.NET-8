using IMS.CoreBusinsess;
using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;

namespace IMS.UseCase.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public AddInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;

		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			await this.inventoryRepository.AddInventoryAsync(inventory);
		}
	}
}
