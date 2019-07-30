using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class LoginAPPController : Controller
    {
        public JsonResult isLoged(string usuario, string contraseña)
        {
            return Json(LoginManager.isLoged(usuario, contraseña), JsonRequestBehavior.AllowGet);
        }
    }
}
