using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class Mes
    {


        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El Mes es Requerido")]
        [StringLength(25, ErrorMessage = "El mes es de 25 caracteres")]
        public string Mese { get; set; }


        public virtual ICollection<Cita> Citas{ get; set; }
    }
}