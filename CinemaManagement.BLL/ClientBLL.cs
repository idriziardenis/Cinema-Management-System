using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class ClientBLL : IBaseCrud<Client>
    {
        private DAClient dal;

        public ClientBLL()
        {
            dal = new DAClient();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Client model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Client obj)
        {
            dal.Delete(obj);
        }

        public Client Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Client Retrieve(Client model)
        {
            return dal.Retrieve(model);
        }

        public List<Client> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public List<Client> RetrieveByGenre(int ID)
        {
            return dal.RetrieveByGenre(ID);
        }

        public void Update(Client model)
        {
            dal.Update(model);
        }

        public int GenreCount(Gender genre)
        {
            return dal.GenreCount(genre);
        }

        public Gender GetGenderDomination()
        {
            return GetGenderDomination();
        }
    }
}
