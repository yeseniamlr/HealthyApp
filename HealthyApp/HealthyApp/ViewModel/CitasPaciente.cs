using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class CitasPaciente
    {

        public int loginId { get; set; }
        public List<Cita> citas { get; set; }

    }
}