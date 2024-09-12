using IMS.CoreBusinsess;
using IMS.UseCase.PluginInterface;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> inventory;
        public InventoryRepository()
        {
            inventory = new List<Inventory>()
            {
                new Inventory() { InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2 },
                new Inventory() { InventoryId = 2, InventoryName = "Bike Body", Quantity = 10, Price = 15 },
                new Inventory() { InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 20, Price = 8 },
                new Inventory() { InventoryId = 4, InventoryName = "Bike Padels", Quantity = 20, Price = 1 },
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return await Task.FromResult(inventory);
            }
            return inventory.Where(x => x.InventoryName.Contains(x.InventoryName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
