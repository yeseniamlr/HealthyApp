using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Rol
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El TipoRol es Requerido")]
        [StringLength(45, ErrorMessage = "El tiporol es de 45 caracteres")]
        public string TipoRol { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}