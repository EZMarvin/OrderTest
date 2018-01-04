using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Model.Common;

namespace OrderManagement.Model
{
    public class Account : Entity
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public ICollection<Order> OrderList { get; set; }
    }
}
