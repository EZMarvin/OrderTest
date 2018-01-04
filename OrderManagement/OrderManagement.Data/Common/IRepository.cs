using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Data.Common
{
    public interface IRepository<T> where T : class
    {
        string Add(T entity);

        string Update(T entity);

        string Delete(T entity);

        T GetbyId(int id);

        IEnumerable<T> GetAll();
    }
}
