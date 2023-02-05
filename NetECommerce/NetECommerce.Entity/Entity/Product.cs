        using NetECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.Entity.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}
