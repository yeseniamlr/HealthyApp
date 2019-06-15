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

        [ForeignKey("Mes")]
        [Required(ErrorMessage = "El campo MesID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un numero entero")]
        public int MesID { get; set; }
        public Mes Mes { get; set; }

        [ForeignKey("Dia_Semana")]
        [Required(ErrorMessage = "El campo MesID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un numero entero")]
        public int Dia_SemanaID { get; set; }
        public Dia_Semana Dia_Semana { get; set; }

        [Required(ErrorMessage = "Horario Requerido")]
        [StringLength(10, ErrorMessage ="El Horario es de 10 caracteres")]
        public string Horario { get; set; }

        [Required(ErrorMessage = "Dia Requerido")]
        public int Dia_Numero { get; set; }

        
        

    }
}