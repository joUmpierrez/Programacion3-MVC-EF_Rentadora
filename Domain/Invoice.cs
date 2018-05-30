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
    public class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int id { get; set; }

        [Required(ErrorMessage = "La fecha es un dato requerido.")]
        public virtual DateTime date { get; set; }

        [Required(ErrorMessage = "El numero de RUT es un dato requerido.")]
        public virtual int rut { get; set; }

        [Required(ErrorMessage = "El nombre es un dato requerido.")]
        public virtual string name { get; set; }

        [Required(ErrorMessage = "La linea de factura es un dato requerido.")]
        public virtual List<InvoiceLine> InvoiceLines { get; set; }

        public Invoice()
        {
            date = DateTime.Today.Date;
        }
    }
}
