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
    public class Boat : Service
    {
        [Required(ErrorMessage = "El numero de pasajeros es un dato requerido.")]
        public virtual int numPassengers { get; set; }

        [Required(ErrorMessage = "El tipo de vehiculo es un dato requerido.")]
        public virtual string type { get; set; }

        [Required(ErrorMessage = "La marca es un dato requerido.")]
        public virtual string brand { get; set; }

        [Required(ErrorMessage = "El modelo es un dato requerido.")]
        public virtual string model { get; set; }

        [Required(ErrorMessage = "El numero de barco es un dato requerido.")]
        [MaxLength(20, ErrorMessage = "El numero de barco no puede tener mas de 20 caracteres.")]
        [Index(IsUnique = true)]
        public virtual string competitorCode { get; set; }
    }
}
