using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.BLL.AbstractService
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();

        string CreateSupplier(Supplier Supplier);

        string DeleteSupplier(Supplier Supplier);

        string UpdateSupplier(Supplier Supplier);

        Supplier FindSupplier(int id);
    }
}
