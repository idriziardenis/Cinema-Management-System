using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class TicketBLL : IBaseCrud<Ticket>
    {
        private DATicket dal;

        public TicketBLL()
        {
            dal = new DATicket();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Ticket model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Ticket obj)
        {
            dal.Delete(obj);
        }

        public Ticket Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Ticket Retrieve(Ticket model)
        {
            return dal.Retrieve(model);
        }

        public List<Ticket> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public List<Ticket> RetrieveTodaysTickets()
        {
            return dal.RetrieveTodaysTickets();
        }

        public void Update(Ticket model)
        {
            dal.Update(model);
        }

        public int GetNumberOfTicketOfMovie(Movie m)
        {
            return dal.GetNumberOfTicketOfMovie(m);
        }

        public int NumberOfMostWatchedMovie()
        {
            return dal.NumberOfMostWatchedMovie();
        }

        public Movie MostWatchedMovie()
        {
            return dal.MostWatchedMovie();
        }
    }
}
