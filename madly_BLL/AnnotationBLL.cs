using System.Collections.Generic;
using madly_DAL;
using madly_models.Models;

namespace madly_BLL
{
    public class AnnotationBLL 
    {
        private readonly AnnotationDAL _dal;

        public AnnotationBLL(AnnotationDAL dal)
        {
            _dal = dal;
        }

        public void Update(Annotation UpdatedAnnotation)
        {
            _dal.Update(UpdatedAnnotation);
        }

        public void Create(Annotation Annotation)
        {
            _dal.Create(Annotation);
        }

        public void Delete(int id)
        {
            _dal.Delete(id);
        }

        public IList<Annotation> GetAllByUserId(string userId)
        {
            var annotations = _dal.GetAllByUserId(userId);
            return annotations;
        }

        public Annotation GetById(int id)
        {
            var annotation = _dal.GetById(id);
            return annotation;
        }
    }
}