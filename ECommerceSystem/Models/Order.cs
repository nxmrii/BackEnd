using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceSystem.Models
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }

      
        [Required]
        public DateTime orderDate { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; }

        [Required]
        [MaxLength(30)]
        public string status { get; set; } = "Pending";

        [Required]
        [MaxLength(300)]
        public string shippingAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string paymentMethod { get; set; }

        //forignKey
        [ForeignKey("User")]
        public int userId { get; set; }

        // Navigation Property
        public User? User { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
