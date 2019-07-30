using HealthyApp.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Areas.Api.Controllers
{
    public class MenuAPPController : Controller
    {
        public JsonResult Menu(int id, int Dia, int Tiempo)
        {
            return Json(MenuManager.Menu(id, Dia, Tiempo), JsonRequestBehavior.AllowGet);
        }
    }
}
