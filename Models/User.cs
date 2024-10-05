using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("email")]
        [MaxLength(100)]
        public required string Email { get; set; }

        [Column("password")]
        [MaxLength(100)]
        public required string Password { get; set; }

        [Column("idRol")]
        public required int IdRol { get; set; }

        [ForeignKey("IdRol")]
        public Rol Rol { get; set; }
    }
}