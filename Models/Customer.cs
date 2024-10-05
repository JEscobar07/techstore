using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column("name")]
        [Required]
        [MaxLength(255)]
        public string Name {get; set;}

        [Column("address")]
        [MaxLength(255)]
        public string? Address {get; set;}

        [Column("phoneNumber")]
        [MaxLength(100)]
        public string? PhoneNumber {get; set;}

        [Column("email")]
        [Required]
        [MaxLength(100)]
        public string Email {get; set;}
    }
}