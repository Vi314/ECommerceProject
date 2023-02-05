using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.BLL.AbstractService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();

        string CreateOrder(Order Order);

        string DeleteOrder(Order Order);

        string UpdateOrder(Order Order);

        Order FindOrder(int id);
    }
}
