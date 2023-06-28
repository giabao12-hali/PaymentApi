using Payment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Entities
{
	public class PaymentDestination : BaseAuditableEntity
	{
		public string Id { get; set; } = string.Empty;
		public string? DesLogo { get; set; } = string.Empty;
		public string? DesSortName { get; set; } = string.Empty;
		public int DesSortIndex { get; set; }
		public string ParentId { get; set; } = string.Empty;
		public bool IsActive { get; set; }
	}
}
