using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Comida
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El platillo es Requerido")]
        [StringLength(45, ErrorMessage = "La fecha es de 45 caracteres")]
        public string Platillo { get; set; }

        public virtual ICollection<Mi_Menu> Mi_Menus { get; set; }


    }
}