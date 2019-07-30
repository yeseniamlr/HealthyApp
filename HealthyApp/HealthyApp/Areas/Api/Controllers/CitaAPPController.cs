using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class CitaAPPController : Controller
    {
        public JsonResult VerificarCita(string code, int id)
        {
            return Json(CitaManager.VerificarCita(id), JsonRequestBehavior.AllowGet);
        }

    }
}
