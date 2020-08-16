using System.Collections.Generic;
using System.Linq;
using madly_DAL.DataSettings;
using madly_models;
using madly_models.Interfaces;

namespace madly_DAL
{
    public class UserDAL : IUser<User>
    {
        private MadlyContext _context;

        public UserDAL(MadlyContext context)
        {
            _context = context;
        }

        public void Update(User UpdatedUser)
        {
            var currentUser = GetById(UpdatedUser.Id);
            
            currentUser.Email = UpdatedUser.Email;
            currentUser.Name = UpdatedUser.Name;
            currentUser.Phone = UpdatedUser.Phone;
            
            _context.Users.Add(currentUser);
            _context.SaveChanges();
        }

        public void Create(User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var User = GetById(id);
            _context.Users.Remove(User);
        }

        public IList<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetById(string id)
        {
            var User = _context.Users.Find(id);
            return User;
        }

        public User GetByEmail(string email)
        {
            var User = _context.Users.Find(email);
            return User;
        }
    }
}