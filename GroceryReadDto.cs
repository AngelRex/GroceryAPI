using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Dtos
{
    public class GroceryReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public double WarehousePrice { get; set; }

        [Required]
        public double InstantSaving { get; set; }

        [Required]
        public double YourCost { get; set; }

    }
}
