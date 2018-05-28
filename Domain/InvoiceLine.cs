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
    public class InvoiceLine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int id { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es un dato requerido.")]
        public virtual string description { get; set; }

        [Required(ErrorMessage = "La fecha de fin es un dato requerido.")]
        public virtual int quantity { get; set; }

        [Required(ErrorMessage = "El servicio es un dato requerido.")]
        public virtual double cost { get; set; }

        [Required(ErrorMessage = "El empleado es un dato requerido.")]
        public virtual Rent rent { get; set; }
    }
}
