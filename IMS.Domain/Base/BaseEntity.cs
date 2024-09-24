using IMS.Infrastructure.Interface;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Base
{
	public class BaseEntity : IBaseEntity
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public DateTimeOffset? CreatedAt { get; set; }

		public string CreatedBy { get; set; }

		public DateTimeOffset? UpdatedAt { get; set; }

		public string UpdatedBy { get; set; }

		public DateTimeOffset? DeletedAt { get; set; }

		public string DeletedBy { get; set; }
	}
}
