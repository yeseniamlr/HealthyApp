using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class ProgresoCreate
    {

        [Required(ErrorMessage="La medida de la cintura es obligatoria")]
        public decimal Medida_Cintura { get; set; }

        [Required(ErrorMessage = "El peso es obligatorio")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "La medida de la cadero es obligatoria")]
        public decimal Medida_Cadera { get; set; }

        [Required(ErrorMessage = "La estatura es obligatoria")]
        public decimal Estatura { get; set; }

        [Required(ErrorMessage = "La edad metabolica es obligatoria")]
        public decimal Edad_Metabolica { get;set; }



    }
}