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

        [ForeignKey("Login")]
        [Required(ErrorMessage = "El campo LoginID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un numero entero")]
        public int LoginID { get; set; }
        public Login Login { get; set; }

    

        [Required(ErrorMessage = "Horario Requerido")]
        [StringLength(20, ErrorMessage ="El Horario es de 20 caracteres")]
        public string Horario { get; set; }

        [Required(ErrorMessage = "Fecha")]
        public DateTime Fecha { get; set; }

        
        

    }
}