using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Consultorio
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Calle Requerida")]
        [StringLength(40, ErrorMessage = "La calle es de 40 caracteres")]
        public string Calle { get; set; }

        [Required(ErrorMessage ="Numero Exterior es Requerido")]
        public int Numero_Exterior { get; set; }

        [Required(ErrorMessage = "Numero Interior es Requerido")]
        public int Numero_Interior { get; set; }

        [Required(ErrorMessage = "Municipio Requerido")]
        [StringLength(40, ErrorMessage = "El Municipio es de 40 caracteres")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Estado Requerido")]
        [StringLength(25, ErrorMessage = "El Estado es de 25 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Codigo Postal es Requerido")]
        public int Codigo_Postal { get; set; }

        public virtual ICollection<Mi_Nutriologo> Mi_Nutriologos{ get; set; }


    }
}