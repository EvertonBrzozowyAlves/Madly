using System;
using System.ComponentModel.DataAnnotations;

namespace madly_models.Models
{
    public abstract class Base
    {
        public Base()
        {
            RegisterDate ??= DateTime.Now;
        }

        [Key]
        public int Id { get; private set; }
        public DateTime? RegisterDate { get; private set; }
    }
}