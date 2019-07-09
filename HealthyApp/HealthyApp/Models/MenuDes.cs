using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class MenuDes
    {
        [Key, Column(Order = 0)]
        [ForeignKey("MenuSemanal")]
        public int MenuSemanalID { get; set;}
        public MenuSemanal MenuSemanal { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Dia")]
        public int DiaID { get; set; }
        public Dia Dia { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Tiempo")]
        public int TiempoID { get; set; }
        public Tiempo Tiempo { get; set; }

        [Key, Column(Order = 3)]
        [ForeignKey("Comida")]
        public int ComidaID { get; set; }
        public Comida Comida { get; set; }
    }
}