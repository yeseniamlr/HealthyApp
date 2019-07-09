using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HealthyApp.Models
{
    public class MenuSemanal
    {

        [Key]
        public int ID { get; set; }


        [ForeignKey("Login")]
        [Required(ErrorMessage = "El campo LoginID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ser un numero entero")]
        public int LoginID { get; set; }
        public Login Login { get; set; }

        public virtual ICollection<MenuDes> MenuDes { get; set; }




    }
}