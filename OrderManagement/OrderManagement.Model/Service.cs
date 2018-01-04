using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Model.Common;

namespace OrderManagement.Model
{
    public class Service : Entity
    {
        public string Name { get; set; }
        public OrderType OrderType { get; set; }
    }
}
