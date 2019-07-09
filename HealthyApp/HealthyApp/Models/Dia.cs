using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Dia
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Descripcion")]
        [StringLength(26, ErrorMessage = "La Descripcion es de 26")]
        public string Descripcion{ get; set; }

        public virtual ICollection<MenuDes> MenuDes { get; set; }
    }
}