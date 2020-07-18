using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class RoleBLL : IBaseCrud<Role>
    {
        private DARole dal;

        public RoleBLL()
        {
            dal = new DARole();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Role model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Role obj)
        {
            dal.Delete(obj);
        }

        public Role Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Role Retrieve(Role model)
        {
            return dal.Retrieve(model);
        }

        public List<Role> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Role model)
        {
            dal.Update(model);
        }
    }
}
