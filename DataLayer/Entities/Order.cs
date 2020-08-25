using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public Customer Customer { get; set; } //Ref
        public ICollection<OrderProduct> Products { get; set; }
    }
}
