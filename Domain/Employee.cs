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
    public class Employee : Person
    {
        [Required(ErrorMessage = "El numero de empleado es un dato requerido.")]
        [Index(IsUnique = true)]
        public virtual int employeeNum { get; set; }

        [Required(ErrorMessage = "La clave es un dato requerido.")]
        public virtual string password { get; set; }
    }
}
