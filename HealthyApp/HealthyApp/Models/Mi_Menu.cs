﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Mi_Menu
    {

        [Key]
        public int ID { get; set; }

        [ForeignKey("Comida")]
        public int ComidaID { get; set; }
        public Comida Comida { get; set; }

        [ForeignKey("Dia_Semana")]
        public int Dia_SemanaID { get; set; }
        public Dia_Semana Dia_Semana { get; set; }

        [Required(ErrorMessage = "El Horario es Requerido")]
        [StringLength(15, ErrorMessage = "El Horario es de 15 caracteres")]
        public string Horario { get; set; }


        
    }
}