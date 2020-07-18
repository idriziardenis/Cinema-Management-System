using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class ChairClassBLL : IBaseCrud<ChairClass>
    {
        private DAChairClass dal;

        public ChairClassBLL()
        {
            dal = new DAChairClass();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(ChairClass model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(ChairClass obj)
        {
            dal.Delete(obj);
        }

        public ChairClass Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public ChairClass Retrieve(ChairClass model)
        {
            return dal.Retrieve(model);
        }

        public List<ChairClass> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(ChairClass model)
        {
            dal.Update(model);
        }
    }
}
