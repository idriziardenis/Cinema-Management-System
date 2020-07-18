using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;
namespace CinemaManagement.BLL
{
    public class HallBLL : IBaseCrud<Hall>
    {
        private DAHall dal;

        public HallBLL()
        {
            dal = new DAHall();
        }

        public int Capacity(int ID)
        {
            return dal.Capacity(ID);
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Hall model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Hall obj)
        {
            dal.Delete(obj);
        }

        public Hall Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Hall Retrieve(Hall model)
        {
            return dal.Retrieve(model);
        }

        public List<Hall> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public List<Hall> RetrieveByTechnology(int ID)
        {
            return dal.RetrieveByTechnology(ID);
        }

        public void Update(Hall model)
        {
            dal.Update(model);
        }

    }
}
