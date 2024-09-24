using IMS.Domain.Base;

namespace IMS.Domain.Entities
{
	public class RestaurantEntity : BaseEntity
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public string Category { get; set; } 

		public bool HasDelivery { get; set; }

		public string? ContactEmail { get; set; }

		public string? ContactNumber { get; set; }

		public List<AddressEntity>? Address { get; set; }

		public List<DishEntity>? Dishes { get; set; }
	}
}
