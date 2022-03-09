using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Produkt Name")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public int? CategoryId { get; set; } //FK
        public Category Category { get; set; } //Ref

        public int? ManufacturerId { get; set; } //FK
        public Manufacturer Manufacturer { get; set; } //Ref

        public ICollection<ProductImage> Images { get; set; } //Ref

        public ICollection<OrderProduct> Orders { get; set; } //Ref
       
    }
}
