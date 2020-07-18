using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class CategoryBLL : IBaseCrud<Category>
    {
        private DACategory dal;

        public CategoryBLL()
        {
            dal = new DACategory();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(Category model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(Category obj)
        {
            dal.Delete(obj);
        }

        public Category Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public Category Retrieve(Category model)
        {
            return dal.Retrieve(model);
        }

        public List<Category> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(Category model)
        {
            dal.Update(model);
        }
    }
}
