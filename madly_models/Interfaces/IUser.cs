using System.Collections.Generic;

namespace madly_models.Interfaces
{
    public interface IUser<T>
    {
        public void Update(T novoUser);
        public void Create(T User);
        public void Delete(string id);
        public IList<T> GetAll();
        public T GetById(string id);
        public T GetByEmail(string email);
    }
}