using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Cita
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Horario Requerido")]
        [StringLength(10, ErrorMessage ="El Horario es de 10 caracteres")]
        public string Horario { get; set; }

        [Required(ErrorMessage = "Dia Requerido")]
        public int Dia_Numero { get; set; }

        [ForeignKey("Dia_Semana")]
        public int IdDia_Semana { get; set; }
        public Dia_Semana Dia_Semana { get; set; }


    }
}