using IMS.Domain.Base;

namespace IMS.Domain.Entities
{
	public class AddressEntity : BaseEntity
	{
		public Guid RestaurantId { get; set; }

		public RestaurantEntity Restaurant { get; set; }

		public string? City { get; set; }

		public string? Street { get; set; }

		public string? PostalCode { get; set; }
	}
}
