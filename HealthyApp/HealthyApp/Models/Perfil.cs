using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Perfil
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "El Nombre es Requerido")]
        [StringLength(25, ErrorMessage = "El nombre es de 25 caracteres")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El Apellido es Requerido")]
        [StringLength(25, ErrorMessage = "El apellido es de 25 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Edad es un campo requerido")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El Genero es Requerido")]
        [StringLength(15, ErrorMessage = "El Genero es de 15 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La Foto es Requerida")]
        public string Foto_paciente { get; set; }

        [ForeignKey("Progreso")]
        public int ProgresoID { get; set; }
        public Progreso Progreso { get; set; }


    }
}