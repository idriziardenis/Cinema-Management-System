using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class CashPaymentDetailsBLL : IBaseCrud<CashPaymentDetails>
    {
        private DACashPaymentDetails dal;

        public CashPaymentDetailsBLL()
        {
            dal = new DACashPaymentDetails();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(CashPaymentDetails model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(CashPaymentDetails obj)
        {
            dal.Delete(obj);
        }

        public CashPaymentDetails Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public CashPaymentDetails Retrieve(CashPaymentDetails model)
        {
            return dal.Retrieve(model);
        }

        public List<CashPaymentDetails> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(CashPaymentDetails model)
        {
            dal.Update(model);
        }
    }
}
