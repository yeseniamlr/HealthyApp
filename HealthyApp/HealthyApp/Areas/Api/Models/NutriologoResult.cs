using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class NutriologoResult
    {

        public string Foto { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Descripcion { get; set; }

        public string Calle { get; set; }

        public int Numero_Exterior { get; set; }

        public int Numero_Interior { get; set; }

        public string Municipio { get; set; }

        public string Estado { get; set; }

        public int Codigo_Postal { get; set; }
    }
}