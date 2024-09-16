using IMS.UseCase.Inventories.Interface;
using IMS.UseCase.PluginInterface;

namespace IMS.UseCase.Inventories
{
    public class DeleteInventoryUseCase : IDeleteInventoryUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(int inventoryId)
		{
			await this.inventoryRepository.DeleteInventoryByIdAsync(inventoryId);
		}
	}
}
