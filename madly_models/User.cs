using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace madly_models
{
    public class User
    {
        public User()
        {
            RegisterDate ??= DateTime.Now;
            Id ??= Guid.NewGuid().ToString();
        }

        [Key, MaxLength(50), ForeignKey("UserId")]
        public string Id { get; private set; }

        [Required, DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? RegisterDate { get; private set; }

        [Required, Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        
        [MaxLength(15), Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(30)]
        public string Password { get; set; }

        public ICollection<Annotation> Annotations { get; set; } = new List<Annotation>();

    }
}