using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;


namespace CinemaManagement.BLL
{
    public class ChairBLL : IBaseCrud<Chair>
    {
        private DAChair dal;

        public ChairBLL()
        {
            dal = new DAChair();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Chair model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Chair obj)
        {
            dal.Delete(obj);
        }

        public Chair Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Chair RetrieveByRC(int row,int column)
        {
            return dal.RetrieveByRC(row, column);
        }

        public Chair Retrieve(Chair model)
        {
            return dal.Retrieve(model);
        }

        public List<Chair> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Chair model)
        {
            dal.Update(model);
        }

        public bool isCreated(int row, int column)
        {
            return dal.isCreated(row, column);
        }
    }
}
