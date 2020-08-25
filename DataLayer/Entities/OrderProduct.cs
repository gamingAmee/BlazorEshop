using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class OrderProduct
    {
        public int OrderId { get; set; } //PK/FK
        public Order Order { get; set; } //Ref

        public int ProductId { get; set; } //PK/FK
        public Product Product { get; set; } //Ref

        public int Pieces { get; set; }
    }
}
