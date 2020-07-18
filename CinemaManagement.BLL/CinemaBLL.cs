using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class CinemaBLL : IBaseCrud<Cinema>
    {
        private DACinema dal;

        public CinemaBLL()
        {
            dal = new DACinema();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Cinema model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Cinema obj)
        {
            dal.Delete(obj);
        }

        public Cinema Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Cinema Retrieve(Cinema model)
        {
            return dal.Retrieve(model);
        }

        public List<Cinema> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Cinema model)
        {
            dal.Update(model);
        }
    }
}
