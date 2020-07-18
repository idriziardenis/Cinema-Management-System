using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class ScheduleBLL : IBaseCrud<Schedule>
    {
        private DASchedule dal;

        public ScheduleBLL()
        {
            dal = new DASchedule();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Schedule model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Schedule obj)
        {
            dal.Delete(obj);
        }

        public Schedule Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Schedule Retrieve(Schedule model)
        {
            return dal.Retrieve(model);
        }

        public List<Schedule> RetrieveALL()
        {
            return dal.RetrieveALL();
        }


        public List<Movie> RetrieveMoviesShowingToday()
        {
            return dal.RetrieveMoviesShowingToday();
        }

        public void Update(Schedule model)
        {
            dal.Update(model);
        }
    }
}
