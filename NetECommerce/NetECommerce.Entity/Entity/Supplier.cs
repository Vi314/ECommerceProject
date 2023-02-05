using NetECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.Entity.Entity
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public List<Product> Products { get; set; }
    }
}
