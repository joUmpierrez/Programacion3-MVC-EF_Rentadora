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
    public class Car : Service
    {
        [Required(ErrorMessage = "El numero de puertas es un dato requerido.")]
        public virtual int numDoors { get; set; }

        [Required(ErrorMessage = "El tipo de vehiculo es un dato requerido.")]
        public virtual string type { get; set; }

        [Required(ErrorMessage = "La marca es un dato requerido.")]
        public virtual string brand { get; set; }

        [Required(ErrorMessage = "El modelo es un dato requerido.")]
        public virtual string model { get; set; }

        [Required(ErrorMessage = "El color es un dato requerido.")]
        public virtual string color { get; set; }

        [Required(ErrorMessage = "El numero de chasis es un dato requerido.")]
        [Index(IsUnique = true)]
        public virtual int chasisNum { get; set; }

        [Required(ErrorMessage = "El numero de motor es un dato requerido.")]
        [Index(IsUnique = true)]
        public virtual int motorNum { get; set; }

        [Required(ErrorMessage = "El numero de matricula es un dato requerido.")]
        [MaxLength(20, ErrorMessage = "El numero de matricula no puede tener mas de 20 caracteres.")]
        [Index(IsUnique = true)]
        public virtual string registerNum { get; set; }
    }
}
