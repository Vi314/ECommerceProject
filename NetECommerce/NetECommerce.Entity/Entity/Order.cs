using NetECommerce.Entity.Base;
using NetECommerce.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.Entity.Entity
{
    public class Order : BaseEntity
    {
        public DateTime? DeliveredDate { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
