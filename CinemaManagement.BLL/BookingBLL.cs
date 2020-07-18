using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL 
{
    public class BookingBLL : IBaseCrud<Booking>
    {
        private DABooking dal;

        public BookingBLL()
        {
            dal = new DABooking();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Booking model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Booking obj)
        {
            dal.Delete(obj);
        }

        public Booking Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Booking Retrieve(Booking model)
        {
            return dal.Retrieve(model);
        }

        public List<Booking> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Booking model)
        {
            dal.Update(model);
        }

        public List<Booking> RetrieveBySchedule(int ID)
        {
            return dal.RetrieveBySchedule(ID);
        }
        public Booking RetrieveByChair(int ID)
        {
            return dal.RetrieveByChair(ID);
        }

        public Booking RetrieveByChairAndSchedule(int ChairID, int ScheduleID)
        {
            return dal.RetrieveByChairAndSchedule(ChairID, ScheduleID);
        }
    }
}
