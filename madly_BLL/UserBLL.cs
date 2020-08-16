using System.Collections.Generic;
using madly_DAL;
using madly_models;
using madly_models.Interfaces;

namespace madly_BLL
{
    public class UserBLL : IUser<User>
    {
        private readonly UserDAL _dal;

        public UserBLL(UserDAL dal)
        {
            _dal = dal;
        }

        public void Update(User user)
        {
            _dal.Update(user);
        }

        public void Create(User user)
        {
            _dal.Create(user);
        }

        public void Delete(string id)
        {
            _dal.Delete(id);
        }

        public IList<User> GetAll()
        {
            var users = _dal.GetAll();
            return users;
        }


        public User GetById(string id)
        {
            var user = _dal.GetById(id);
            return user;
        }

        public User GetByEmail(string email)
        {
            var user = _dal.GetByEmail(email);
            return user;
        }
    }
}