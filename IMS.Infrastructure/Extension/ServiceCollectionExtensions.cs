using IMS.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IMS.Infrastructure.Extension
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
		{
			return services.AddDbContext<DataContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
		}
	}
}
