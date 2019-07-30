using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class CitaReturn
    {
        public string Horario { get; set; }

        public int Dia { get; set; }

        public int Mes { get; set; }

        public int Año { get; set; }
    }
}