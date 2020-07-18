using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class EventDetailsBLL : IBaseCrud<EventDetails>
    {
        private DAEventDetails dal;

        public EventDetailsBLL()
        {
            dal = new DAEventDetails();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(EventDetails model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(EventDetails obj)
        {
            dal.Delete(obj);
        }

        public EventDetails Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public EventDetails Retrieve(EventDetails model)
        {
            return dal.Retrieve(model);
        }

        public List<EventDetails> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(EventDetails model)
        {
            dal.Update(model);
        }
    }
}
