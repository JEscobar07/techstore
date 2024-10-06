using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models
{
    [Table("OrderProducts")]
    public class OrderProduct
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column("amountBought")]
        [Required]
        public int AmountBought  {get; set;}

        [Column("idProduct")]
        [Required]
        public int IdProduct {get; set;}

        [Column("idOrder")]
        [Required]
        public int IdOrder {get; set;}

        [ForeignKey("IdProduct")]
        public Product Product {get; set;}

        [ForeignKey("IdOrder")]
        public Order Order {get; set;}

    }
}