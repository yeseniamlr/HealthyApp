using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Dia_Semana
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Dia Requerido")]
        [StringLength(15, ErrorMessage = "El Dia es de 15 caracteres")]
        public string Dia { get; set; }

        public virtual ICollection<Cita> Citas {get;set;}
    }
}