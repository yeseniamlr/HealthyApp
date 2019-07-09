using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyApp.ViewModel
{
    public class ComidasCreate
    {
        [Display(Name ="Descripcion")]
        [Required(ErrorMessage = "La descricion es Requerido")]
        [StringLength(255, ErrorMessage = "La descripcion es de 255 caracteres")]
        public string Descripcion { get; set; }


    }
}