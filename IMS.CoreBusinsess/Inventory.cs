﻿using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusinsess
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string InventoryName { get; set; } = string.Empty;

		[Range(0, int.MaxValue, ErrorMessage = "Quantity must be greator or equal to 0.")]
		public int Quantity { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Price must be greator or equal to 0.")]
		public double Price { get; set; }
    }
}
