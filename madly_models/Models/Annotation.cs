using madly_models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace madly_models.Models
{
    public class Annotation : Base
    {
        [Required]
        public DateTime ValidationDate { get; set; }

        [Required]
        public bool Validated { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public AnnotationLevel Level { get; set; }

        public string Remarks { get; set; }

        [Required]
        public int Votes { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public AnnotationType AnnotationType { get; set; }
    }




}