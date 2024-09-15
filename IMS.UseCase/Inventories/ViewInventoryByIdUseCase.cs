using IMS.CoreBusinsess;
using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;

namespace IMS.UseCase.Inventories
{
	public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}
		public async Task<Inventory> ExecuteAsync(int inventoryId)
		{
			return await this.inventoryRepository.GetInventoryByIdAsync(inventoryId);
		}
	}
}