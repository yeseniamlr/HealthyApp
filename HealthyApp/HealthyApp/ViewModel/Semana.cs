using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class Semana
    {
        public Lunes lunes { get; set;}
        public Martes martes { get; set;}
        public Miercoles miercoles { get; set; }
        public Jueves jueves  { get; set; }
        public Viernes viernes { get; set; }
        public Sabado sabado { get; set; }
        public Domingo domingo { get; set; }
        public int MenuSemanalID { get; set; }

    }
}