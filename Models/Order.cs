using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("Orders")]
    public class Order
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("creationDate")]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column("idCustomer")]
        [Required]
        public int IdCustomer { get; set; }

        [Column("idStateOrder")]
        [Required]
        public int IdStateOrder { get; set; }

        [ForeignKey("IdCustomer")]
        public Customer Customer { get; set; }

        [ForeignKey("IdStateOrder")]
        public StateOrder StateOrder { get; set; }
    }
}