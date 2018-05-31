using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Domain
{
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int id { get; set; }

        [Required(ErrorMessage = "El nombre es un dato requerido.")]
        public virtual string name { get; set; }

        [Required(ErrorMessage = "El apellido es un dato requerido.")]
        public virtual string lastname { get; set; }

        [Required(ErrorMessage = "El telefono es un dato requerido.")]
        public virtual string telephoneNum { get; set; }

        [Required]
        public virtual bool active { get; set; }

        public Person()
        {
            active = true;
        }
    }
}
