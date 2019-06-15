using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Progreso
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El IMC es Requerido")]
        public decimal IMC { get; set; }

        [Required(ErrorMessage = "La Medida de la cintura es Requerida")]
        public decimal Medida_Cintura { get; set; }

        [Required(ErrorMessage = "El Peso es Requerido")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "La Medida de la Cadera es Requerida")]
        public decimal Medida_Cadera { get; set; }

        [Required(ErrorMessage = "La Estatura es Requerida")]
        public decimal Estatura { get; set; }

        [Required(ErrorMessage = "La Edad Metabolica es Requerida")]
        public decimal Edad_Metabolica { get; set; }

        [Required(ErrorMessage = "La Fecha es Requerida")]
        [StringLength(15, ErrorMessage = "La fecha es de 15 caracteres")]
        public string Fecha{ get; set; }

        public virtual ICollection<Progreso> Progresos { get; set; } 





    }
}