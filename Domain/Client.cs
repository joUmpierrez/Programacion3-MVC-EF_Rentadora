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
    public class Client : Person
    {
        [Required(ErrorMessage = "La cedula es un dato requerido.")]
        [Index(IsUnique = true)]
        public virtual int idCard { get; set; }
    }
}
