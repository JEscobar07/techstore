using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("Categories")]
    public class Category
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column("name")]
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}

        [Column("description")]
        [MaxLength(255)]
        public string? Description {get; set;}
    }
}