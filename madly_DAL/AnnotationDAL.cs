using System.Collections.Generic;
using System.Linq;
using madly_DAL.DataSettings;
using madly_models;
using madly_models.Interfaces;

namespace madly_DAL
{
    public class AnnotationDAL : IAnnotation<Annotation>
    {
        private MadlyContext _context;
        
        public AnnotationDAL(MadlyContext context)
        {
            _context = context;
        }

        public void Update(Annotation newAnnotation)
        {
            var currentAnnotation = GetById(newAnnotation.Id);
            
            currentAnnotation.Level = newAnnotation.Level;
            currentAnnotation.Remarks = newAnnotation.Remarks;
            currentAnnotation.Reason = newAnnotation.Reason;

            _context.Annotations.Update(currentAnnotation);
            _context.SaveChanges();
        }

        public void Create(Annotation Annotation)
        {
            _context.Annotations.Add(Annotation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Annotation = GetById(id);
            _context.Annotations.Remove(Annotation);
            _context.SaveChanges();
        }

        public IList<Annotation> GetAllByUserId(string userId)
        {
            var annotations = _context.Annotations.Where(a => a.UserId == userId).ToList();
            return annotations;
        }

        public Annotation GetById(int id)
        {
            var annotations = _context.Annotations.Find(id);
            return annotations;
        }
    }
}