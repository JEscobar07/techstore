using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace techstore.Models
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name {get; set;}

        [Column("description")]
        [MaxLength(255)]
        public string? Description {get; set;}
    }
}