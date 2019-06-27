using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class ProgresoResult
    {

        [Display(Name="Historial")]
        public List<Progreso> progresos { get; set; }

    }
}