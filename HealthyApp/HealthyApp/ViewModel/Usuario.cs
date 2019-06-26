using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class Usuario
    {

        [Required(ErrorMessage = "El Nombre es Requerido")]
        [StringLength(25, ErrorMessage = "El nombre es de 25 caracteres")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El Apellido es Requerido")]
        [StringLength(25, ErrorMessage = "El apellido es de 25 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Edad es un campo requerido")]
        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El Genero es Requerido")]
        [StringLength(15, ErrorMessage = "El Genero es de 15 caracteres")]
        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La Foto es Requerida")]
        public string Foto_paciente { get; set; }
    }
}