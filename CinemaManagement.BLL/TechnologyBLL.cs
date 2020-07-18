using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class TechnologyBLL : IBaseCrud<Technology>
    {
        private DATechnology dal;

        public TechnologyBLL()
        {
            dal = new DATechnology();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Technology model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Technology obj)
        {
            dal.Delete(obj);
        }

        public Technology Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Technology Retrieve(Technology model)
        {
            return dal.Retrieve(model);
        }

        public List<Technology> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Technology model)
        {
            dal.Update(model);
        }
    }
}
