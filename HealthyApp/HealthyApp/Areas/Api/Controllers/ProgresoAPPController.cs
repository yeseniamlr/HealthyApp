using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class ProgresoAPPController : Controller
    {
        public JsonResult Progreso(string code, int id)
        {
            return Json(ProgresoManager.Progreso(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Grafica(string code, int id)
        {
            return Json(ProgresoManager.Grafica(id), JsonRequestBehavior.AllowGet);
        }
    }
}
