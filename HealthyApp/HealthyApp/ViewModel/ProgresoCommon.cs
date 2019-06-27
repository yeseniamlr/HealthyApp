using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class ProgresoCommon
    {
        
        public int IDPaciente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string Genero { get; set; }

        public string Foto_paciente { get; set; }

        public ProgresoResult progresoResult { get; set; }
        public ProgresoCreate progresoCreate { get; set; }



    }
}