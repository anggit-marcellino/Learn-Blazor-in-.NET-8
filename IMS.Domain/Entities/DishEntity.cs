using IMS.Domain.Base;

namespace IMS.Domain.Entities
{
	public class DishEntity : BaseEntity
	{
		public Guid RestaurantId {  get; set; }

		public RestaurantEntity Restaurant { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }
	}
}
