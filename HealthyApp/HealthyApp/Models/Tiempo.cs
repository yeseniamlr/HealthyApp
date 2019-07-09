using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Tiempo
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "La descrpcion es Requerido")]
        [StringLength(25, ErrorMessage = "La descripcion es de 25 caracteres")]
        public string Descripcion { get; set; }

        public virtual ICollection<MenuDes> MenuDes { get; set; }
    }
}