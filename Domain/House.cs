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
    public class House : Service
    {
        [Required(ErrorMessage = "El numero de habitaciones es un dato requerido.")]
        public virtual int numRooms { get; set; }

        [Required(ErrorMessage = "El numero de banios es un dato requerido.")]
        public virtual int numBathrooms { get; set; }

        [Required(ErrorMessage = "La superficie edificada es un dato requerido.")]
        public virtual int buildSurface { get; set; }

        [Required(ErrorMessage = "La direccion es un dato requerido.")]
        public virtual string address { get; set; }

        [Required(ErrorMessage = "La ciudad es un dato requerido.")]
        public virtual string city { get; set; }

        [Required(ErrorMessage = "La piscina es un dato requerido.")]
        public virtual bool pool { get; set; }

        [Required(ErrorMessage = "El garage es un dato requerido.")]
        public virtual bool garage { get; set; }
    }
}
