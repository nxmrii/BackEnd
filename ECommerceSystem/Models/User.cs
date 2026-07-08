using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceSystem.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MaxLength(256)]
        public string passwordHash { get; set; }

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }

        [MaxLength(20)]
        public string? phoneNumber { get; set; }

        [MaxLength(300)]
        public string? address { get; set; }

        [Required]
        public DateTime registrationDate { get; set; }

        public bool isActive { get; set; } = true;

        // Navigation Property
        public ICollection<Order>? Orders { get; set; }
    }
}
