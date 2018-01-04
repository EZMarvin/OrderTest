using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Data.Common;
using OrderManagement.Data.Repositories;
using OrderManagement.Model;

namespace OrderManagement.Service
{
    public class OrderServices : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderServices()
        {
            _orderRepository = new OrderRepository();
        }

        public string AddOrder(Order order)
        {
            return _orderRepository.Add(order);
        }

        public string DeleteOrder(Order order)
        {
            return _orderRepository.Delete(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public string UpdateOrder(Order order)
        {
            return _orderRepository.Update(order);
        }
    }

    public interface IOrderService
    {
        string AddOrder(Order order);
        string DeleteOrder(Order order);
        string UpdateOrder(Order order);
        IEnumerable<Order> GetAllOrders();
    }
}
