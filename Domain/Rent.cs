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
    public class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int id { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es un dato requerido.")]
        public virtual DateTime startDate { get; set; }

        [Required(ErrorMessage = "La fecha de fin es un dato requerido.")]
        public virtual DateTime endDate { get; set; }

        [Required(ErrorMessage = "El servicio es un dato requerido.")]
        public virtual Service service { get; set; }

        [Required(ErrorMessage = "El empleado es un dato requerido.")]
        public virtual Employee employee { get; set; }

        [Required(ErrorMessage = "El cliente es un dato requerido.")]
        public virtual Client client { get; set; }

        [Required]
        public virtual bool active { get; set; }

        public Rent()
        {
            active = true;
        }
    }
}
