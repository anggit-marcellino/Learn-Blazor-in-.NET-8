using IMS.CoreBusinsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCase.PluginInterface
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name = "");

        Task AddInventoryAsync(Inventory inventory);
	}
}
