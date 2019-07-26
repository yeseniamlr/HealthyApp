using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class ProgresoReturn
    {
        public decimal IMC { get; set; }

        public decimal Medida_Cintura { get; set; }

        public decimal Peso { get; set; }

        public decimal Medida_Cadera { get; set; }
     
        public decimal Estatura { get; set; }
      
        public decimal Edad_Metabolica { get; set; }
        
     
    }
}