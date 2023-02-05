using NetECommerce.BLL.Abstract;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.BLL.Service
{
    public class SupplierService :ISupplierService
    {
        private IRepository<Supplier> _repository;

        public SupplierService(IRepository<Supplier> repository)
        {
            _repository = repository;
        }

        public string CreateSupplier(Supplier Supplier)
        {
            try
            {
                return _repository.Create(Supplier);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string DeleteSupplier(Supplier Supplier)
        {
            try
            {
                return _repository.Delete(Supplier);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Supplier FindSupplier(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _repository.GetAll();
        }

        public string UpdateSupplier(Supplier Supplier)
        {
            try
            {
                Supplier.Status = Entity.Enum.Status.Updated;
                return _repository.Update(Supplier);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
