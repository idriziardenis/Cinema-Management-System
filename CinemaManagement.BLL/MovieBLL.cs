using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class MovieBLL : IBaseCrud<Movie>
    {
        private DAMovie dal;

        public MovieBLL()
        {
            dal = new DAMovie();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Movie model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Movie obj)
        {
            dal.Delete(obj);
        }

        public Movie Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Movie Retrieve(string Title)
        {
            return dal.Retrieve(Title);
        }
        public Movie Retrieve(Movie model)
        {
            return dal.Retrieve(model);
        }

        public List<Movie> RetrieveALL()
        {
            return dal.RetrieveALL();
        }
        public void Update(Movie model)
        {
            dal.Update(model);
        }
    }
}
