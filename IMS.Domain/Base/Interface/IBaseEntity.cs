using System;

namespace IMS.Infrastructure.Interface
{
	public interface IBaseEntity
	{
		public Guid Id { get; set; }

		DateTimeOffset? CreatedAt { get; set; }

		string CreatedBy { get; set; }

		DateTimeOffset? UpdatedAt { get; set; }

		string UpdatedBy { get; set; }

		DateTimeOffset? DeletedAt { get; set; }

		string DeletedBy { get; set; }
	}
}
