using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Cita
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Horario Requerido")]
        [StringLength]
        public string Horario { get; set; }


    }
}