using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthyApp.Models
{
    public class Mi_Nutriologo
    {

        [Key]
        public int ID { get; set; }

        [ForeignKey("Consultorio")]
        public int ConsultorioID { get; set; }
        public Consultorio Consultorio { get; set; }

        [Required(ErrorMessage = "La Foto es Requerida")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "El Nombre Es Requerido")]
        [StringLength(20, ErrorMessage = "El nombre es de 20 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido Es Requerido")]
        [StringLength(30, ErrorMessage = "El apellido es de 30 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Cedula Es Requerida")]
        [StringLength(25, ErrorMessage = "La cedula es de 25 caracteres")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El Telefono Es Requerido")]
        [StringLength(15, ErrorMessage = "El telefono es de 15 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La Descripcion Es Requerida")]
        [StringLength(100, ErrorMessage = "La descripcion es de 100 caracteres")]
        public string Descripcion { get; set; }

       


    }
}