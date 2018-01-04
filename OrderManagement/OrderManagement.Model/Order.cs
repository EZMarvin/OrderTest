using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Model.Common;

namespace OrderManagement.Model
{
    public enum OrderType
    {
        Paramed,
        CreditCheck,
        CriminalReport
    }
    public class Order : Entity
    {
        

        public OrderType OrderType { get; set; }
        public int Total { get; set; }

        public Account Account { get; set; }

        public int ServiceCount { get; set; }
        public ICollection<Service> ServiceList { get; set; }
    }
}
