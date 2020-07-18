using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BO
{
    public interface IBaseCrud<T>
    {
        void Create(T model);
        void Update(T model);
        void Delete(int id);
        void Delete(T obj);
        T Retrieve(int id);
        T Retrieve(T model);
        List<T> RetrieveALL();
        int Count();
    }
}
