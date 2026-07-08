using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    public class OrderItem
    {
        [Key]
        public int orderItemId { get; set; }

        [ForeignKey("Order")]
        public int orderId { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }

        [Required]
        [Range(1,999)]                                                                                                                                                                                                                                                                                            
        public int quantity { get; set; }

        //Navigation properties
        public Order? Order { get; set; }
        public Product? Product { get; set; }

    }
}
