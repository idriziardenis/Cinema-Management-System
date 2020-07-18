using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class GenderBLL : IBaseCrud<Gender>
    {
        private DAGender dal;

        public GenderBLL()
        {
            dal = new DAGender();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Gender model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Gender obj)
        {
            dal.Delete(obj);
        }

        public Gender Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Gender Retrieve(Gender model)
        {
            return dal.Retrieve(model);
        }

        public List<Gender> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Gender model)
        {
            dal.Update(model);
        }
    }
}
