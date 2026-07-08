using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceSystem.Models
{
    public class Category
    {
        
            [Key]
            public int categoryId { get; set; }

            [Required]
            [MaxLength(100)]
            public string categoryName { get; set; }

            [MaxLength(500)]
            public string? description { get; set; }

            [MaxLength(300)]
            public string? imageUrl { get; set; }

            // Navigation Property
            public ICollection<Product>? Products { get; set; }
        
    }
}
