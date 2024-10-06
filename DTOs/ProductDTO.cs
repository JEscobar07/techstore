using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.DTOs
{
    public class ProductDTO
    {

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int AmountProducts { get; set; }

        [Required]
        public int IdCategory { get; set; }
    }
}