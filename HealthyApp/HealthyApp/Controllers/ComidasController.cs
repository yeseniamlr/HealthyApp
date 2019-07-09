using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class ComidasController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        [HttpGet]

        public ActionResult Comidas()
        {



            if (Session["UserName"] != null)
            {

                ComidasCommon model = new ComidasCommon();

                model.Comidas = new ComidasCreate();

                model.ComidasResult = new ComidasResult();

                var query = (from c in dbContext.comidas
                             select c).ToList();

                List<Comidas> comidas = new List<Comidas>();

                foreach (var c in query)
                {
                    Comidas comida = new Comidas();

                    comida.ID = c.ID;
                    comida.Descripcion = c.Descripcion;

                    comidas.Add(comida);
                }

                model.ComidasResult.comidas = comidas;



                return View(model);
            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }





        }
        [HttpPost]

        public ActionResult Comidas(ComidasCommon model)
        {
            if (Session["UserName"] != null)
            {
                if (ModelState.IsValid)
                {

                    Comida comida = new Comida();
                    comida.Descripcion = model.Comidas.Descripcion;
                    dbContext.comidas.Add(comida);

                    dbContext.SaveChanges();
                    return RedirectToAction("Comidas", "Comidas");




                }
                else
                {
                    model.ComidasResult = new ComidasResult();

                    var query = (from c in dbContext.comidas
                                 select c).ToList();

                    List<Comidas> comidas = new List<Comidas>();

                    foreach (var c in query)
                    {
                        Comidas comida = new Comidas();

                        comida.ID = c.ID;
                        comida.Descripcion = c.Descripcion;

                        comidas.Add(comida);
                    }

                    model.ComidasResult.comidas = comidas;


                    return RedirectToAction("Comidas", "Comidas");

                }
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        public ActionResult Borrar(int id)
        {

            var query = (from md in dbContext.MenuDes where md.ComidaID == id select md).ToList();

            if (query.Count==0)
            {
                var comida = (from c in dbContext.comidas where c.ID == id select c).SingleOrDefault();

                dbContext.comidas.Remove(comida);
                dbContext.SaveChanges();
                return RedirectToAction("Comidas", "Comidas");
            }
            else
            {
                return RedirectToAction("Comidas", "Comidas");

            }
        }

    }
}