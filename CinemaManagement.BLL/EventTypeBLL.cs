using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class EventTypeBLL : IBaseCrud<EventType>
    {
        private DAEventType dal;

        public EventTypeBLL()
        {
            dal = new DAEventType();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(EventType model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(EventType obj)
        {
            dal.Delete(obj);
        }

        public EventType Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public EventType Retrieve(string name)
        {
            return dal.Retrieve(name);
        }

        public EventType Retrieve(EventType model)
        {
            return dal.Retrieve(model);
        }

        public List<EventType> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(EventType model)
        {
            dal.Update(model);
        }
    }
}
