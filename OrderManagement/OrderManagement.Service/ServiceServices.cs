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
    public class ServiceServices : IServiceService
    {
        private readonly IRepository<Model.Service> _serviceRepository;

        public ServiceServices()
        {
            _serviceRepository = new ServiceRepository();
        }
        public string AddService(Model.Service service)
        {
            return _serviceRepository.Add(service);
        }

        public string DeleteAccount(Model.Service service)
        {
            return _serviceRepository.Delete(service);
        }

        public IEnumerable<Model.Service> GetAllAccounts()
        {
            return _serviceRepository.GetAll();
        }

        public Model.Service GetById(int id)
        {
            return _serviceRepository.GetbyId(id);
        }

        public string UpdateAccount(Model.Service service)
        {
            return _serviceRepository.Update(service);
        }
    }

    public interface IServiceService
    {
        string AddService(Model.Service service);
        string DeleteAccount(Model.Service service);
        string UpdateAccount(Model.Service service);
        Model.Service GetById(int id);
        IEnumerable<Model.Service> GetAllAccounts();
    }
}
