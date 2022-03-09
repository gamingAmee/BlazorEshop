using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        [Required]
        public string Image { get; set; }

        public int ProductId { get; set; } //FK
        public Product Product { get; set; } //Ref
    }
}
