using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.Entity.Entity
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}
