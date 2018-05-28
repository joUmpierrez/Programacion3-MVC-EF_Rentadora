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
    public abstract class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int id { get; set; }

        [Required(ErrorMessage = "El costo por dia es un dato requerido.")]
        public virtual double costPerDay { get; set; }
    }
}
