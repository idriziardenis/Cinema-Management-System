using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL;
using CinemaManagement.BO;

namespace CinemaManagement.BLL
{
    public class UserBLL : IBaseCrud<User>
    {
        private DAUser dal;

        public UserBLL()
        {
            dal = new DAUser();
        }

        public int Count()
        {
            return dal.Count();
        }

        public void Create(User model)
        {
            dal.Create(model);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public void Delete(User obj)
        {
            dal.Delete(obj);
        }

        public User Retrieve(int id)
        {
            return dal.Retrieve(id);
        }

        public User Retrieve(User model)
        {
            return dal.Retrieve(model);
        }

        public List<User> RetrieveByRole(int ID)
        {
            return dal.RetrieveByRole(ID);
        }

        public List<User> RetrieveALL()
        {
            return dal.RetrieveALL();
        }

        public void Update(User model)
        {
            dal.Update(model);
        }

        public void UpdateActivity(User obj)
        {
            dal.UpdateActivity(obj);
        }

        public User Login(string UserName, string Password)
        {
            return dal.Login(UserName, Password);
        }
    }
}
