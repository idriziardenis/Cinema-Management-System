using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class PaymentBLL : IBaseCrud<Payment>
    {
        private DAPayment dal;

        public PaymentBLL()
        {
            dal = new DAPayment();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Payment model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Payment obj)
        {
            dal.Delete(obj);
        }

        public Payment Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Payment Retrieve(Payment model)
        {
            return dal.Retrieve(model);
        }

        public List<Payment> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Payment model)
        {
            dal.Update(model);
        }
    }
}
