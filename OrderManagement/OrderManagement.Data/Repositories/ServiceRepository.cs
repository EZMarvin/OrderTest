using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Data.Common;
using OrderManagement.Model;

namespace OrderManagement.Data.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        public string Add(Service entity)
        {
            return "Add a " + entity.Name + " Service.";
        }

        public string Delete(Service entity)
        {
            return "Delete a " + entity.Name + " Service.";
        }

        public IEnumerable<Service> GetAll()
        {
            throw new NotImplementedException();
        }

        public Service GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Service entity)
        {
            return "Update a " + entity.Name + " Service.";
        }
    }
}
