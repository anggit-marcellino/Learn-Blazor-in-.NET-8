using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> inventories;
        public InventoryRepository()
        {
			inventories = new List<Inventory>()
            {
                new Inventory() { InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2 },
                new Inventory() { InventoryId = 2, InventoryName = "Bike Body", Quantity = 10, Price = 15 },
                new Inventory() { InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 20, Price = 8 },
                new Inventory() { InventoryId = 4, InventoryName = "Bike Padels", Quantity = 20, Price = 1 },
            };
        }

		public Task AddInventoryAsync(Inventory inventory)
		{
            if (inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            var maxId = inventories.Max(x => x.InventoryId);
            inventory.InventoryId = maxId + 1;

            inventories.Add(inventory); 
            
            return Task.CompletedTask;
		}

		public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return await Task.FromResult(inventories);
            }
            return inventories.Where(x => x.InventoryName.Contains(x.InventoryName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
