using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class NutriologoAPPController : Controller
    {
        public JsonResult Nutriologo()
        {
            return Json(NutriologoManager.Nutriologo(), JsonRequestBehavior.AllowGet);
        }

    }
}
