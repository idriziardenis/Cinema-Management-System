using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;
namespace CinemaManagement.BLL
{
    public class EventBLL : IBaseCrud<Event>
    {
        private DAEvent dal;

        public EventBLL()
        {
            dal = new DAEvent();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Event model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Event obj)
        {
            dal.Delete(obj);
        }

        public Event Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Event Retrieve(Event model)
        {
            return dal.Retrieve(model);
        }

        public List<Event> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public List<Event> RetrieveByType(int ID)
        {
            return dal.RetrieveByType(ID);
        }

        public List<Event> RetrieveActiveEvents()
        {
            return dal.RetrieveActiveEvents();
        }

        public void Update(Event model)
        {
            dal.Update(model);
        }


    }
}
