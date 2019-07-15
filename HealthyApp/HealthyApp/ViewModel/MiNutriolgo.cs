using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class MiNutriolgo
    {
        [Required(ErrorMessage = "El Usuario es Requerido")]
        [StringLength(45, ErrorMessage = "El usuario es de 45 caracteres")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "El Password es Requerido")]
        [StringLength(45, ErrorMessage = "El password es de 45 caracteres")]
        public string Password { get; set; }

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

        [Required(ErrorMessage = "Calle Requerida")]
        [StringLength(40, ErrorMessage = "La calle es de 40 caracteres")]
        public string Calle { get; set; }

        [Required(ErrorMessage = "Numero Exterior es Requerido")]
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

    }
}