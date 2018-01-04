using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Data.Common;
using OrderManagement.Model;

namespace OrderManagement.Data.Repositories
{

    public class OrderRepository : IRepository<Order>
    {

        // Tempory List
        List<Order> orderList;

        // Add test data
        public OrderRepository()
        {
            Account testuser1 = new Account { Id = 1, Name = "Test Customer #1" };
            Account testuser2 = new Account { Id = 1, Name = "Test Customer #2" };
            Account testuser3 = new Account { Id = 1, Name = "Test Customer #3" };
            orderList = new List<Order>();
            orderList.Add(new Order { Id = 100, Account = testuser1, ServiceCount = 2 });
            orderList.Add(new Order { Id = 101, Account = testuser2, ServiceCount = 3 });
            orderList.Add(new Order { Id = 102, Account = testuser3, ServiceCount = 1 });
        }

        public string Add(Order entity)
        {
            return "Add a "+ entity.OrderType +" Order.";
        }

        public string Delete(Order entity)
        {
            return "Delete a " + entity.OrderType + " Order.";
        }

        public IEnumerable<Order> GetAll()
        {
            return orderList;
        }

        public Order GetbyId(int id)
        {
            return orderList.Find(e => e.Id == id);
        }

        public string Update(Order entity)
        {
            return "Update a " + entity.OrderType + " Order.";
        }
    }
}
