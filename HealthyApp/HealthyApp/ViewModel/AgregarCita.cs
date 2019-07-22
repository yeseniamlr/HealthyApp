using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class AgregarCita
    {
        
        [Required(ErrorMessage = "El campo LoginID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un numero entero")]
        public int LoginID { get; set; }
        
        [Required(ErrorMessage = "Horario Requerido")]
        [StringLength(20, ErrorMessage = "El Horario es de 20 caracteres")]
        public string Horario { get; set; }

        [Required(ErrorMessage = "Dia Requerido")]
        [Range(0, 31, ErrorMessage = "El Dia debe ser entero")]
        public int Dia { get; set; }

        [Required(ErrorMessage = "Mes Requerido")]
        [Range(0, 12, ErrorMessage = "El Mes debe ser entero")]
        public int Mes { get; set; }

        [Required(ErrorMessage = "Año Requerido")]
        [Range(0,9999, ErrorMessage = "El numero debe ser entero")]
        public int Año { get; set; }
    }
}