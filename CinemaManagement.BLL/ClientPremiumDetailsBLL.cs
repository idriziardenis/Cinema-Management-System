using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class ClientPremiumDetailsBLL : IBaseCrud<ClientPremiumDetails>
    {
        private DAClientPremiumDetails dal;

        public ClientPremiumDetailsBLL()
        {
            dal = new DAClientPremiumDetails();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(ClientPremiumDetails model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(ClientPremiumDetails obj)
        {
            dal.Delete(obj);
        }

        public ClientPremiumDetails Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public ClientPremiumDetails Retrieve(ClientPremiumDetails model)
        {
            return dal.Retrieve(model);
        }

        public List<ClientPremiumDetails> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(ClientPremiumDetails model)
        {
            dal.Update(model);
        }
    }
}
