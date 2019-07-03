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

        [Display(Name ="Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Display(Name = "Genero")]
        public string Genero { get; set; }

        public string Foto_paciente { get; set; }

        public ProgresoResult progresoResult { get; set; }
        public ProgresoCreate progresoCreate { get; set; }

        public int LoginID { get; set; }
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }



    }
}