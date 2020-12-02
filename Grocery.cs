using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Models
{
    public class Grocery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public double WarehousePrice { get; set; }

        [Required]
        public double InstantSaving { get; set; }

        [Required]
        public double YourCost { get; set; }

        [Required]
        public double CurrentInventory { get; set; }

    }
}
