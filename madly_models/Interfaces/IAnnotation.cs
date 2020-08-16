using System.Collections.Generic;

namespace madly_models.Interfaces 
{
    public interface IAnnotation<T>
    {
        public void Update(T annotation);
        public void Create(T annotation);
        public void Delete(int id);
        public IList<T> GetAllByUserId(string userId);
        public T GetById(int id);
    }
}