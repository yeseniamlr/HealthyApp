using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Login
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Rol")]
        public int RolID { get; set; }
        public Rol Rol { get; set; }

        [Required(ErrorMessage = "El Usuario es Requerido")]
        [StringLength(45, ErrorMessage = "El usuario es de 45 caracteres")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "El Password es Requerido")]
        [StringLength(45, ErrorMessage = "El password es de 45 caracteres")]
        public string Password { get; set; }

        public virtual ICollection<Perfil> Perfils { get; set; }
        public virtual ICollection<MenuSemanal> MenuSemanals { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }
        public virtual ICollection<Mi_Nutriologo> Mi_Nutriologos { get; set;}

    }
}