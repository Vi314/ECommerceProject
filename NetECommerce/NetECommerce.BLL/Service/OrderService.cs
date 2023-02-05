using NetECommerce.BLL.Abstract;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.BLL.Service
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public string CreateOrder(Order Order)
        {
            try
            {
                return _repository.Create(Order);
            }
            catch (Exception ex)
            {
               return ex.Message;
            }

        }

        public string DeleteOrder(Order Order)
        {
            try
            {
                return _repository.Delete(Order);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Order FindOrder(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _repository.GetAll();
        }

        public string UpdateOrder(Order Order)
        {
            try
            {
                Order.Status = Entity.Enum.Status.Updated;
                return _repository.Update(Order);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
