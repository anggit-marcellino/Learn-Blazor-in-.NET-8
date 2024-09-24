using IMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IMS.Infrastructure.Persistance
{
	public class DataContext : DbContext
	{

		public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

		public DbSet<RestaurantEntity> Restaurants { get; set; }

		public DbSet<AddressEntity> Addresses { get; set; }

		public DbSet<DishEntity> Dishes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<RestaurantEntity>()
				.HasMany(x => x.Address)
				.WithOne(x => x.Restaurant)
				.HasForeignKey(x => x.RestaurantId)
				.IsRequired();

			modelBuilder.Entity<RestaurantEntity>()
				.HasMany(x => x.Dishes)
				.WithOne(x => x.Restaurant)
				.HasForeignKey(x => x.RestaurantId)
				.IsRequired();

		}
    }

	//public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
	//{
	//	public DataContext CreateDbContext(string[] args)
	//	{
	//		var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
	//		optionsBuilder.UseSqlServer("Server=localhost,1433;Database=IMSDb;User ID=sa;Password=YourStrong@Passw0rd; TrustServerCertificate=True;");

	//		return new DataContext(optionsBuilder.Options);
	//	}
	//}
}
 