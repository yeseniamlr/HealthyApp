using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class AgregarMenu
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public bool isSelected { get; set; }
        public int menuID { get; set; }
        public int diaID { get; set; }
        public int tiempoID { get; set; }

    }
}