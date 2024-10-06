using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("Products")]
    public class Product
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column("description")]
        [MaxLength(255)]
        public string? Description { get; set; }

        [Column("price")]
        [Required]
        public double Price {get; set;}

        [Column("amountProducts")]
        [Required]
        public int AmountProducts {get; set;}

        [Column("idCategory")]
        [Required]
        public int IdCategory {get; set;}

        [ForeignKey("IdCategory")]
        public Category Category {get; set;}
        
    }
}