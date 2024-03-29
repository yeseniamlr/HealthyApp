﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Comida
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "La descricion es Requerido")]
        [StringLength(255, ErrorMessage = "La descripcion es de 255 caracteres")]
        public string Descripcion { get; set; }

        public virtual ICollection<MenuDes> MenuDes { get; set; }

    }
}