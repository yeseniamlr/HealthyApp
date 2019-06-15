using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Mi_Menu
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El Horario es Requerido")]
        [StringLength(15, ErrorMessage = "El Horario es de 15 caracteres")]
        public string Horario { get; set; }


        [ForeignKey("Comida")]
        public int IdComida { get; set; }
        public Comida Comida { get; set; }

        [ForeignKey("Dia Semana")]
        public int IdDia_Semana { get; set; }
        public Dia_Semana Dia_Semana { get; set; }
    }
}