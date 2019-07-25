using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class PerfilAPPController : Controller
    {
        public JsonResult Inicio(string code,int id)
        {
            return Json(PerfilManager.Inicio(id), JsonRequestBehavior.AllowGet);
        }

    }
}
